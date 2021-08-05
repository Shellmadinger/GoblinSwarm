using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

   public void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            Debug.Log("Game is not paused");
        }

        else
        {
            Time.timeScale = 0f;
            isPaused = true;
            Debug.Log("Game is paused");
        }
    }
}
