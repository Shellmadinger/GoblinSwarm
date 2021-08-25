using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Goblin")]
public class GoblinInstance : ScriptableObject 
{
    public int goblinHealth;
    public float goblinSpeed;
    public float maxGoblinSpeed;
    public float scoreThreshold;
    public float scoreThresholdIncreaseFactor;
    public float goblinSpeedIncreaseFactor;
    
    
}
