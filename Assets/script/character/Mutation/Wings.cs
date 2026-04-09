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
        }
        if (Mutation_Jauge < 100)
        {
            Mutation_Activate = false;

        }


        if (Mutation_Activate == true)
        {
            Mutation_Activation_Double_Saut();
            

        }
        if (Mutation_Activate == false)
        {
            Character.Number_Of_Jump_Max = 1;
        }
    }
      



    void Mutation_Activation_Double_Saut()
    {
        Character.Number_Of_Jump_Max = 2;
    }

    void Aerial_Dash()
    {

    }
    


    

   





}
