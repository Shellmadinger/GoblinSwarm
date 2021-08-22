using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public static bool gameOver = false;
    public GameObject gameOverMenu;
    public string sceneToLoadQuit;

    private void Start()
    {
        Resume();
    }

    public void Resume()
    {
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        gameOver = false;
    }

    public void SetGameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        gameOver = true;
    }


    public void SetQuit()
    {
        SceneManager.LoadScene(sceneToLoadQuit);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

}
