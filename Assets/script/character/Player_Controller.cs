using UnityEngine;

public class Player_Controller : MonoBehaviour

{



    public int JumpForce = 200;
    public int SpeedBase = 2;
    public int GravityForce = 1;
    public int DashForce = 5;
    public GameObject PlayerCharacter;
    public Rigidbody2D PCBody;
    public Co
   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


        if(Input.GetKey(KeyCode.LeftArrow))
        {
            PlayerCharacter.transform.position = new Vector2(-1, 0) * SpeedBase;
        }
    
        if(Input.GetKey(KeyCode.RightArrow))
        {
            PlayerCharacter.transform.position = new Vector2(1, 0) * SpeedBase;

            if(Input.GetKeyDown(KeyCode.E))
            {
                PCBody.AddForceX(DashForce);
            }
        }
         

        if( Input.GetKeyDown(KeyCode.Space))
        {
            PCBody.AddForceY(JumpForce); 
        }
    
    
    
    }
}
