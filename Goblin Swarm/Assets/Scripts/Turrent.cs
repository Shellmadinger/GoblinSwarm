using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turrent : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public GameOver gameOverTrigger;

    private void Start()
    {
        gameOverTrigger.Resume();
    }
    // Update is called once per frame
    void Update()
    {
        if (!Pause.isPaused && !GameOver.gameOver)
        {
            TouchRotate();
        }
       
    }

    void TouchRotate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                transform.rotation = Quaternion.LookRotation(Vector3.forward, Camera.main.ScreenToWorldPoint(touch.position));
                Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            }
        }
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goblin")
        {
            gameOverTrigger.SetGameOver();
        }
    }
}
