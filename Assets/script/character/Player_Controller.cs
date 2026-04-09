
using JetBrains.Annotations;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{



    public float JumpForce = 300f;
    public float SpeedBase = 2f;
    public int GravityForce = 1;
    public float DashForce = 10;
    public GameObject PlayerCharacter;
    public Rigidbody2D PCBody;
    public LayerMask mask;
    public IEnumerator MyCoroutine;
    public float cooldown;
    public bool _amIDashing;
    public PJ_Core_Script Character;
    public Wings Mutation_Wings;
    
   
   
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PCBody.gravityScale = GravityForce;

        var horizontalAxis = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalAxis = -1;

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalAxis = 1;
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (horizontalAxis != 0)
            {
                Dash(horizontalAxis);
                
            }
        }
        if(!_amIDashing)
        {
            PCBody.linearVelocityX = horizontalAxis * SpeedBase;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
           if(Character.Number_Of_Jump > 0)
            {
             PCBody.AddForceY(JumpForce);
             Character.Number_Of_Jump -= 1;
            }

         
      
        }

       
    
    
    }    

    public void Dash(float axisValue)
    {
        if (!_amIDashing)
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f, mask);
            if (hit.collider == true)
            {
                PCBody.linearVelocityX = axisValue * DashForce;
                StartCoroutine(DashCooldown());
                Character.Stamina_Max_Value -= 4f;
                


            }
    }   }    
    public IEnumerator DashCooldown()
    {
        _amIDashing = true;
        yield return new WaitForSeconds(cooldown);
        _amIDashing = false;
    }

    public bool CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f, mask);
        if (hit == true)
        {
            Character.Number_Of_Jump = Character.Number_Of_Jump_Max;
            return true;
            
        }
        else return false;
        
    }


}

