using UnityEngine;
using UnityEngine.SceneManagement;

public class End_OfGame : MonoBehaviour
{

    
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
        SceneManager.LoadScene(8);
    }



}
