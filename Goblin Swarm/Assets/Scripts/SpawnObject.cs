﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    //Initializing Variables
    public GameObject asset;
    public Transform spawnPoint;
    float minTime = 6;
    float maxTime = 10;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnGoblin());
    }

    IEnumerator SpawnGoblin()
    {
       while (true)
       { 
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            GameObject goblin = Instantiate(asset, spawnPoint.transform.position, Quaternion.identity) as GameObject;      
       }
       
    }
}