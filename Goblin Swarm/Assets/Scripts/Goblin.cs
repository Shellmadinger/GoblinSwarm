using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public float scoreThreshold;
    public float scoreThresholdIncreaseFactor;
    public float goblinSpeedIncreaseFactor;
    public float maxGoblinSpeed;
    public Transform objectLook;
    public float goblinSpeed;

    float score;

    private void Start()
    {
        score = FindObjectOfType<HudManager>().GetComponent<HudManager>().goblinKills;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Pause.isPaused && !GameOver.gameOver)
        {
            MoveTowardsObject();
            IncreaseSpeed();
        }
        
    }

    void MoveTowardsObject()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, objectLook.position);
        transform.position = Vector2.MoveTowards(transform.position, objectLook.position, goblinSpeed);
    }

    void IncreaseSpeed()
    {
        if (score >= scoreThreshold && goblinSpeed <= maxGoblinSpeed)
        {
            goblinSpeed += goblinSpeedIncreaseFactor;
            scoreThreshold += scoreThresholdIncreaseFactor;
            Debug.Log("Current Goblin Speed: " + goblinSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            FindObjectOfType<HudManager>().IncreaseScore();
            Destroy(gameObject);  
        }

    }
}
