

using System.Collections;

using UnityEngine;

public class Player_Controller : MonoBehaviour
{



    public float JumpForce ;
    public float SpeedBase ;
    public int GravityForce ;
    public float DashForce ;
    public GameObject PlayerCharacter;
    public Rigidbody2D PCBody;
    public LayerMask mask;
    public IEnumerator MyCoroutine;
    public float cooldown;
    public bool _amIDashing;
    public bool _amIJumping;
    public bool _amIWalking;
    public PJ_Core_Script Character;
    public Wings Mutation_Wings;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public bool Groundistuctch;




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
            spriteRenderer.flipX = true;
            _amIWalking = true; 


        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalAxis = 1;
            spriteRenderer.flipX = false;
            _amIWalking = true;
        }

        if (horizontalAxis == 0)
        {
            _amIWalking = false;
        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Dash_Try");
            if (horizontalAxis != 0)
            {
                Dash(horizontalAxis);

            }
        }
        if (!_amIDashing)
        {
            PCBody.linearVelocityX = horizontalAxis * SpeedBase;

        }

        if(_amIWalking == true)
        {
            animator.SetBool("walk", true);
        }
        else
            animator.SetBool("walk",  false);

        CheckGround(true);
        if (Input.GetKeyDown(KeyCode.Space))
        {
        
            if (Character.Number_Of_Jump > 0)
            {
                _amIJumping = true;
                animator.SetBool("Jump", true);
                PCBody.AddForceY(JumpForce);
                Character.Number_Of_Jump -= 1;
                
            }
            else
            {
                _amIJumping = false;
            }
 
        }
        if (_amIDashing == true)
        animator.SetBool("_Dashing", true);
        else
            animator.SetBool("_Dashing", false);

    }
    

    public void Dash(float axisValue)
    {
        if (!_amIDashing)
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f, mask);
            if (hit.collider == true)
            {
                PCBody.linearVelocityX *= DashForce;
                StartCoroutine(DashCooldown());
               
                



            }
        } }
    public IEnumerator DashCooldown()
    {
        _amIDashing = true;
        yield return new WaitForSeconds(cooldown);
        _amIDashing = false;

    }

    public bool CheckGround(bool bool12)
    {
      
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.01f, mask);
        if (hit == true)
        {

            Character.Number_Of_Jump = Character.Number_Of_Jump_Max;
            animator.SetBool("Jump", false);
            Mutation_Wings.animator.SetBool("DoubleJumping", false);
            bool12 = true;
           
            
        }
        return false;

    }

    private void OnDrawGizmos()
    {
       Gizmos.color = Color.yellow;
       Gizmos.DrawRay(transform.position, Vector3.down * 0.01f); 
    }

}
