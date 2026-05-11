using UnityEngine;

public class Wings : MonoBehaviour
{
    public float Mutation_Jauge;
    public Player_Controller PJ_control;
    public PJ_Core_Script Character;
    public bool Mutation_Activate;
    public Collider2D PJ_Collider;
    public bool Aerial_Dash_Activate;
    public Animator animator;
   



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     


    }

    // Update is called once per frame
    void Update()
    {
    
        if (Mutation_Jauge == 100)
        {
            Mutation_Activate = true;
            DoubleJump();
           
        }
        if (Mutation_Jauge < 100)
        {
            Mutation_Activate = false;

        }

        if (Mutation_Activate == true)
        {
            if (PJ_control._amIJumping == true)
            {
               if(Character.Number_Of_Jump == 1)
                {
                    if (Input.GetKey(KeyCode.Space))
                    {
                        animator.SetBool("DoubleJumping", true);
                    }
                }
                           
                
            }
        }
        else
            animator.SetBool("DoubleJumping", false);
            
    }


    public void DoubleJump()
    {
        Character.Number_Of_Jump_Max = 2;
    }
    
}