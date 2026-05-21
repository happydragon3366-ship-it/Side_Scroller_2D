using UnityEngine;
using UnityEngine.UI;

public class Claws : MonoBehaviour
{
    public PJ_Core_Script PJ_CoreS;
    public Player_Controller PJ_ControlS;
    public Animator Animator;
    public Ennemies_Core_Script Ennemie;
    public Collider2D PJ_Collider;
    public Collider2D Zone_EnnemiTakeDamge;
    public LayerMask Ennemi_LayerMask;
    public bool ColliderTestTrue;
    public SpriteRenderer spriterenderer;
    public Animator animator;
    public bool _IsAttacking;
    public float Mutation_Jauge;
    public bool Mutation_Activate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        ColliderTest();
        

        if (Mutation_Jauge == 100)
        {
            Mutation_Activate = true;
            

        }
        if (Mutation_Jauge < 100)
        {
            Mutation_Activate = false;

        }

    }




    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(Mutation_Activate == true)
        {
            if (PJ_ControlS._amIJumping == false)
            {
                
                if (Input.GetKey(KeyCode.F))
                {
                  _IsAttacking = true;
                   print("op");
                    if (ColliderTestTrue == true)
                    {
                        _IsAttacking = true;
                        Ennemie.PV -= PJ_CoreS.Capacity_Damage;
                    }
                    return;
                }
                
                
            }
            return;
        }       
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
