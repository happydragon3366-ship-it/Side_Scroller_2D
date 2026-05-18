using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{

    public Button KillGameButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Application.Quit();  
    }


}
