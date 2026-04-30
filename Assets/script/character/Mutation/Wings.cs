using UnityEngine;

public class Wings : MonoBehaviour
{
    public float Mutation_Jauge;
    public Player_Controller PJ_control;
    public PJ_Core_Script Character;
    public bool Mutation_Activate;
    public Collider2D PJ_Collider;
    public bool Aerial_Dash_Activate;
    public bool Is_Double_Jumping;
   



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
            AerialDash(0);
        }
        if (Mutation_Jauge < 100)
        {
            Mutation_Activate = false;

        }



       

    }


    public void DoubleJump()
    {
        Character.Number_Of_Jump_Max = 2;
    }

    public void AerialDash(int horizontalAxis)
    {
        if (PJ_control._amIJumping != true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    horizontalAxis = -1;

                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    horizontalAxis = 1;
                }
            }
            

            



           


        }





    }
}