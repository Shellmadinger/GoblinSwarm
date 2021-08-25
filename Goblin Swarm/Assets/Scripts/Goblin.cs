using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public GoblinInstance newGoblin;
    

    Transform objectLook;
    float score;

    private void Start()
    {
        score = FindObjectOfType<HudManager>().GetComponent<HudManager>().goblinKills;
        objectLook = FindObjectOfType<Turrent>().transform;
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
        transform.position = Vector2.MoveTowards(transform.position, objectLook.position, newGoblin.goblinSpeed);
    }

    void IncreaseSpeed()
    {
        if (score >= newGoblin.scoreThreshold && newGoblin.goblinSpeed <= newGoblin.maxGoblinSpeed)
        {
            newGoblin.goblinSpeed += newGoblin.goblinSpeedIncreaseFactor;
            newGoblin.scoreThreshold += newGoblin.scoreThresholdIncreaseFactor;
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
