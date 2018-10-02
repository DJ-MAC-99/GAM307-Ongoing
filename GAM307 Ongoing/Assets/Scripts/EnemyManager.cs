﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    /*
     * Use a coroutine to spawn an enemy at random location 
     * in the game world every second
     * 
     * Spawn a random enemy as above
     * 
     */

    public GameObject[] enemies;
    int maxEnemyCount = 10;
    int currentEnemyCount;
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnEnemy());
        currentEnemyCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnEnemy()
    {
        while (currentEnemyCount < maxEnemyCount)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

            int rnd = Random.Range(0, 3);
            Instantiate(enemies[rnd], spawnPos, transform.rotation);

            yield return new WaitForSeconds(2);
        }
    }

           /* if (currentEnemyCount<maxEnemyCount)
            StartCoroutine(SpawnEnemy());
        else
            StopCoroutine(SpawnEnemy());
            */
}
