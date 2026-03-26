using UnityEngine;

public class Wings : MonoBehaviour
{
    public float Mutation_Jauge;
    public Player_Controller PJ_control;
    public PJ_Core_Script Character;
    public bool Mutation_Activate;
    public Collider2D PJ_Collider;
    public bool Aerial_Dash_Activate;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        

    }

    // Update is called once per frame
    void Update()
    {
        var horizontalAxis = 0;
        

        if (Mutation_Jauge == 100)
        {
            Mutation_Activate = true;
        }
        if (Mutation_Jauge < 100)
        {
            Mutation_Activate = false;

        }

        if (Mutation_Activate == true)
        {
            Mutation_Activation_Double_Saut();
            Aerial_Dash_Activate = true;
        }

       
    }



    void Mutation_Activation_Double_Saut()
    {
        if(Mutation_Activate == true)
        {
           if(PJ_control.Is_Jumping == true)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    PJ_control.PCBody.AddForceY(PJ_control.JumpForce);
                    PJ_control.Is_Jumping = false;
                   
                }

            }
        }
    }

    void Aerial_Dash()
    {
        if (PJ_control.Is_Jumping == true)
        {
            if(Input
        }
    }
    


    

   





}
