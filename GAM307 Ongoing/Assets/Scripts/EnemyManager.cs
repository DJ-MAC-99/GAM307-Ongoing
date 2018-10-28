using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public int enemyCount;

    // Declare variables to hold our enemy prefabs
    public GameObject[] enemies;
    
    void Start ()
    {
        SpawnEnemy();
	}

    public void SpawnEnemy()
    {
        int spawnNumber = 0;
        if (GameManager.instance.difficulty == Difficulty.EASY)
            spawnNumber = 1;
        if (GameManager.instance.difficulty == Difficulty.MEDIUM)
            spawnNumber = 2;
        if (GameManager.instance.difficulty == Difficulty.HARD)
            spawnNumber = 3;


        for (int i = 0; i < spawnNumber; i++)
        {
            //Get a random position
            Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));

            //Instantaite the (random) prefab at a random position
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, transform.rotation);
        }
    }
    
    private void OnEnable()
    {
        GameEvents.OnEnemyDie += OnEnemyDie;
    }

    private void OnDisable()
    {
        GameEvents.OnEnemyDie -= OnEnemyDie;
    }

    void OnEnemyDie()
    {
        enemyCount--;
        SpawnEnemy();
    }

}
