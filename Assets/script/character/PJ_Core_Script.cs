using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using JetBrains.Annotations;


public class PJ_Core_Script : MonoBehaviour
{

    public float PV;
    public float MutationJauge_MaxValue;
    public Rigidbody2D PCRigid_Body;
    public Collider2D PC_Collider;
    public GameObject PC_Character;
    public int Number_Of_Jump;
    public int Number_Of_Jump_Max;
    public Player_Controller PC_Deplacement;
    public float Death_CoolDown;
    public float Capacity_Damage;
    public Wings WingMutation;
    public Snake_Body SnakeMutation;
  
    
    
    
    
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

     MutationActivator();
       
        
        
    
    }

    public void Death()
    {
       
     PC_Deplacement.enabled = false;
     StartCoroutine(ReviveCoolDown());
     PC_Deplacement.enabled = true;
     
    
    }
  
   
    
    public IEnumerator ReviveCoolDown()
    {
        
        yield return new WaitForSeconds(Death_CoolDown);
        PV = 20;
        
    }

    public void MutationActivator()
    {
       if(WingMutation.Mutation_Jauge == 0)
        {
            print("lmpele");
            if (Input.GetKey(KeyCode.L))
            {
                WingMutation.Mutation_Jauge = MutationJauge_MaxValue;
                print("ggggg");
            }

        }
  
        
       if(WingMutation.Mutation_Jauge == 100f)
        {
            if (Input.GetKey(KeyCode.O))
            {
                WingMutation.Mutation_Jauge = 0f;
            }
        }


        if (SnakeMutation.Mutation_Jauge == 0)
        {
            if (Input.GetKey(KeyCode.K))
            {
                SnakeMutation.Mutation_Jauge = MutationJauge_MaxValue;
            }
        }

        if (SnakeMutation.Mutation_Jauge == 100f)
        {
            if (Input.GetKey(KeyCode.I))
            {
                SnakeMutation.Mutation_Jauge = 0f;
            }
        }

    }

}
