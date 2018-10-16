using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {

    public TextMeshProUGUI enemyCountText;
    public TextMeshProUGUI scoreText;


    // Update is called once per frame
    //void Update()
    //{
    //    enemyCountText.text = "Enemy Count" + " - " + EnemyManager.instance.enemyCount.ToString();
    //    scoreText.text = "Score" + " - " + GameManager.instance.scoreTotal.ToString();

    //}

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
        enemyCountText.text = "Enemy Count" + " - " + EnemyManager.instance.enemyCount.ToString();
        scoreText.text = "Score" + " - " + GameManager.instance.scoreTotal.ToString();
    }
}
