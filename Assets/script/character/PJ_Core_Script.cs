using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class PJ_Core_Script : MonoBehaviour
{

    public float PV;
    public float Stamina;
    public Rigidbody2D PCRigid_Body;
    public Collider2D PC_Collider;
    public GameObject PC_Character;
    public Player_Controller PC_Deplacement;
    public float Death_CoolDown;
    public float Capacity_Damage;
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (PV <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
       
        
     StartCoroutine(ReviveCoolDown());
        
    }
  
    public void Stamina_Lack()
    {
        if (Stamina < 5)
        {
            PC_Deplacement.SpeedBase = 1f;
            PC_Deplacement.DashForce = 0;
        
        
        }
    }
    
    public IEnumerator ReviveCoolDown()
    {
        
        yield return new WaitForSeconds(Death_CoolDown);
        PV = 20;
        
    }








}
