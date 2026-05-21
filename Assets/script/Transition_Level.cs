
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition_Level : MonoBehaviour
{
    public Collider2D TransitionZone_ContactCore;
    public PJ_Core_Script Player_Script;
    public int SceneList_Number;
    public Ennemies_Core_Script EnnemiCoreS;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    
    
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag( "Player"))
        {
            Destroy(collision.gameObject);
        }
        else
        {
            int sceneBuildIndex = SceneList_Number;
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
        return;
    }

  




















}
