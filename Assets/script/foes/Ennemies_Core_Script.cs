using UnityEngine;


public class Ennemies_Core_Script : MonoBehaviour
{
    public float PV;
    public string Name;
    public Collider2D DetectionCollider;
    public Collider2D ContactCollider;
    public Rigidbody2D FoesRBody;
    public GameObject Foes;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }



    public void Death()
    {
        if(PV == 0)
        {
            Destroy(Foes);
        }
        
    }





}
