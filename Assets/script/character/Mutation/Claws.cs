using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Claws : MonoBehaviour
{
    public PJ_Core_Script PJ_CoreS;
    public Player_Controller PJ_ControlS;
    public Animator Animator;
    public Ennemies_Core_Script Ennemie;
    public Collider2D PJ_Collider;
    public Collider2D Ennemi_DamageZone;
    public LayerMask Ennemi_LayerMask;
    public bool ColliderTestTrue;
    public SpriteRenderer spriterenderer;
    public Animator animator;
    public bool _IsAttacking;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        ColliderTest();
        Hit();
    }




    public void Hit()
    {
        
        if (PJ_ControlS._amIJumping == false)
        {
            print("hjjh");
           if (Input.GetKey(KeyCode.F))
           { 
             PJ_CoreS.PC_Deplacement.enabled = false;
             animator.SetBool("_IsAttackingAnimation", true);
             _IsAttacking = true;
             print("op");
                PJ_CoreS.PC_Deplacement.enabled = false;
             if (ColliderTestTrue == true)
             {
                _IsAttacking = true;
                PJ_CoreS.PC_Deplacement.enabled = false;
                Ennemie.PV -= PJ_CoreS.Capacity_Damage;
             }
             else _IsAttacking = false; PJ_CoreS.PC_Deplacement.enabled=true;animator.SetBool("_IsAttackingAnimation", false);
                return;           
           }
           else _IsAttacking = false; PJ_CoreS.PC_Deplacement.enabled = true; animator.SetBool("_IsAttackingAnimation", false);
        }  return;
        
        
    }
    


    public void ColliderTest()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.forward, 0.10f, Ennemi_LayerMask);
        if (hit == true)
        {
            ColliderTestTrue = true;
        }
        else ColliderTestTrue = false;
            return;
          
    }

 

}
