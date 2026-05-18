using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition_Level : MonoBehaviour
{
    public Collider2D TransitionZone_ContactCore;
    public PJ_Core_Script Player_Script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(TransitionZone_ContactCore.isTrigger == true)
        {
            SceneManager.LoadSceneAsync
        }
    }


   

    
    











}
