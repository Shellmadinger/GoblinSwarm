using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenu;

    private void Start()
    {
        Resume();
    }
    public void PauseGame()
    {
        if (isPaused)
        {
            Resume();
        }

        else
        {
            SetPause();
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log(isPaused);
    }

   public void SetPause()
   {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
   }

    private void OnApplicationPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void SetQuit()
    {
        Debug.Log("Temp Quit");
    }
}
