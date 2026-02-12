
using Unity.VisualScripting;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{



    public float JumpForce = 200f;
    public float SpeedBase = 2f;
    public int GravityForce = 1;
    public int DashForce = 10;
    public GameObject PlayerCharacter;
    public Rigidbody2D PCBody;
    public float AxeXPositif = 1f;
    public float AxeXNegatif = -1f;
   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        PCBody.gravityScale = GravityForce;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            PCBody.linearVelocityX = AxeXNegatif * SpeedBase ;  

            if(Input.GetKey(KeyCode.E))
            {
                PCBody.linearVelocityX = AxeXNegatif * DashForce;
            }

        }
    
        if(Input.GetKey(KeyCode.RightArrow))
        {
            PCBody.linearVelocityX = AxeXPositif * SpeedBase  ;

            if(Input.GetKey(KeyCode.E))
            {
                PCBody.linearVelocityX = AxeXPositif * DashForce;
            }
        }
         
       
        if( Input.GetKeyDown(KeyCode.Space))
        {
            PCBody.AddForceY(JumpForce); 
        }
    
    
    
    }
}
