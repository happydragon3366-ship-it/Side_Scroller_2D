
using UnityEngine;
using UnityEngine.UI;


public class Ennemies_Core_Script : MonoBehaviour
{
    public float PV;
    public float DamageCapacity;
    public string Name;
    public float SpeedBase;
    public PJ_Core_Script UltimaCore_S;
    public Collider2D DetectionCollider;
    public Collider2D ContactCollider;
    public Rigidbody2D FoesRBody;
    public GameObject Foes;
    public LayerMask Ultima_Layer_Mask;
    public bool UltimaDetectedRight;
    public bool UltimaDetectedLeft;
    public SpriteRenderer spriterenderer;
    public Vector3 Vector;
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
        _IsUltimaNear_Right(UltimaDetectedRight);
        _IsUltimateNear_Left(UltimaDetectedLeft);
        DirectionOnthePlayerLeft();
        DirectionOnthePlayerRight();
        
        
    }



    public void Death()
    {
        if(PV == 0)
        {
            Destroy(Foes);
        }
        
    }

    public void _IsUltimaNear_Right(bool bool2)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 10f, Ultima_Layer_Mask);
        if (hit == true)
        {
            UltimaDetectedRight = true;
        }
        else UltimaDetectedRight = false;
        
    
    }   
    
    public void _IsUltimateNear_Left(bool bool3)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, 5f, Ultima_Layer_Mask);
        if (hit == true)
        {
            UltimaDetectedLeft = true;
        }
        else UltimaDetectedLeft = false;

    }

    public void DirectionOnthePlayerLeft()
    {
        if(UltimaDetectedLeft == true)
        {
            spriterenderer.flipX = true;
            FoesRBody.linearVelocityX = -1 * SpeedBase;
        }
        else spriterenderer.flipX = false;
    }
    

    public void DirectionOnthePlayerRight()
    {
        if (UltimaDetectedRight == true)
        {
            FoesRBody.linearVelocityX = 1 * SpeedBase;
            
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("gghhh");
        if(UltimaDetectedLeft == true)
        {
            UltimaCore_S.PCRigid_Body.AddForce(-Vector, ForceMode2D.Impulse);
            UltimaCore_S.PV -= DamageCapacity;
            print("mgerL");
        }

        if (UltimaDetectedRight == true)
        {
            UltimaCore_S.PCRigid_Body.AddForce(Vector, ForceMode2D.Impulse);
            UltimaCore_S.PV -= DamageCapacity;
            print("mger");
        }


    }


}
