using System;

using UnityEngine;

public class Snake_Body : MonoBehaviour
{
    public float Mutation_Jauge;
    public Player_Controller PJ_control;
    public PJ_Core_Script Character;
    public bool Mutation_Activate;
    public Collider2D PJ_Collider;
    public LayerMask Foes_Mask;
    public LayerMask Nothings;
    public float NewDashForce;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mutation_Jauge == 100)
        {
            Mutation_Activate = true;
        }
        if(Mutation_Jauge <100)
        {
            Mutation_Activate = false;
            
        }
        
        if(Mutation_Activate == true)
        {
            Mutation_Activation();
        }

        if(Mutation_Activate == false)
        {
            
            PJ_Collider.excludeLayers = Nothings;
        }


    }


    public void Mutation_Activation()
    {
        if(Mutation_Activate == true)
        {

            PJ_control.DashForce = NewDashForce;
            if (PJ_control._amIDashing == true)
            {
                PJ_Collider.excludeLayers = Foes_Mask;

            }
            else
            {
                PJ_Collider.excludeLayers = Nothings;
                
            }
        }
               

        
        
          
       
    }












}
