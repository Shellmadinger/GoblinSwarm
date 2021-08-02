using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float scoreThreshold;
    public float scoreThresholdIncreaseFactor;
    int changeWhichStat = 1;
    Goblin goblinSpeed;
    HudManager score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChooseIncrease()
    {
        if (score.goblinKills >= scoreThreshold)
        {
            IncreaseGoblinSpeed();
            scoreThreshold += scoreThresholdIncreaseFactor;
        }


       
    }

    void IncreaseGoblinSpeed()
    {

    }
}
