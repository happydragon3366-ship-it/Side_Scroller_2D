
using JetBrains.Annotations;
using System.Collections;
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
    public LayerMask mask;
    public IEnumerator MyCoroutine;
    public float cooldown;
    private bool _amIDashing;
    private PJ_Core_Script Character;

   
    

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

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f, mask);
            if(hit.collider == true )
            {
                PCBody.AddForceY(JumpForce);
            }
        }
    }    

    private void Dash(float axisValue)
    {
        if (!_amIDashing)
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.4f, mask);
            if (hit.collider == true)
            {
                PCBody.linearVelocityX = axisValue * DashForce;
                StartCoroutine(DashCooldown());
            }
        }    }
    private IEnumerator DashCooldown()
    {
        _amIDashing = true;
        yield return new WaitForSeconds(cooldown);
        _amIDashing = false;
    }

    public void Desactivate_Input()
    {
        if(Character.PV <= 0)
        {
            enabled = false;
        }
    }
 
      
    






}

