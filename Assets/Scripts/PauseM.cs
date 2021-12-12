using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseM : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseMUI;
    
    
    public void ResumeB () 
    {
        PauseMUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void PauseB()
    {
        PauseMUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
  
    void Update(){
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(GamePaused)
            {
                ResumeB();
            }else
            {
                PauseB();
            }
        }
        
    }

}



