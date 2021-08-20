using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public string sceneToLoad;

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
        SceneManager.LoadScene(sceneToLoad);
    }
}
