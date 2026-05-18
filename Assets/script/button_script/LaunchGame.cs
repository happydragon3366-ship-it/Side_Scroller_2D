using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LaunchGame : MonoBehaviour
{
    public Button Initiate;
    public int SceneList_Number;

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
        int sceneBuildIndex = SceneList_Number;
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }






}
