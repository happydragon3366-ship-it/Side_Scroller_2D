using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using JetBrains.Annotations;


public class PJ_Core_Script : MonoBehaviour
{

    public float PV;
    public float Stamina_Max_Value = 15;
    public Rigidbody2D PCRigid_Body;
    public Collider2D PC_Collider;
    public GameObject PC_Character;
    public int Number_Of_Jump = 1;
    public int Number_Of_Jump_Max;
    public Player_Controller PC_Deplacement;
    public float Death_CoolDown;
    public float Stamina_Gain_CoolDown_Value;
    public float Capacity_Damage;
    public float Stamina_Lack_During_Effect;
    public bool Stamina_Lack_Verification;
    public bool Stamina_Gain_Verification;
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PV == 0)
        {
            Death();
            
        }

        if (Stamina_Max_Value > 15) 
        {
            Stamina_Max_Value = 15;    
        }
        
        if (Stamina_Max_Value < 15) 
        {
            
            StartCoroutine (Stamina_Gain());
           

        }
        
        if (Stamina_Max_Value == 0f)
        {
            
            Stamina_Lack_Verification = true;
            

        }
       

        if(Stamina_Lack_Verification == true)
        {
            StartCoroutine(Stamina_Lack());
        }


       
    
    
    
    }

    public void Death()
    {
       
     PC_Deplacement.enabled = false;
     Stamina_Max_Value = 0;
     StartCoroutine(ReviveCoolDown());
     PC_Deplacement.enabled = true;
     Stamina_Max_Value = 15;
    
    }
  
   
    
    public IEnumerator ReviveCoolDown()
    {
        
        yield return new WaitForSeconds(Death_CoolDown);
        PV = 20;
        
    }

   
    public IEnumerator Stamina_Gain()
    {
        
        
        
            Stamina_Max_Value = Stamina_Max_Value + 1f;
            yield return new WaitForSeconds(Stamina_Gain_CoolDown_Value);
        
        



    }

    public IEnumerator Stamina_Lack()
    {
        
       
        
            PC_Deplacement.SpeedBase = 1f;
            PC_Deplacement.DashForce = 0;
            print("zizi");
        
        yield return new WaitForSeconds(Stamina_Lack_During_Effect);
        Stamina_Lack_Verification = false;
        
    }


}
