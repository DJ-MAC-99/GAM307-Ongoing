using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {

    public TextMeshProUGUI enemyCountText;
    public TextMeshProUGUI scoreText;

    //Update is called once per frame

    //void Update()
    //{
    //    enemyCountText.text = "Enemy Count: <color=red>" + EnemyManager.instance.enemyCount.ToString();
    //    scoreText.text = "Score: <color=green>" + GameManager.instance.score.ToString();
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
        scoreText.text = "Score: <color=green>" + GameManager.instance.score.ToString();
        enemyCountText.text = "Enemy Count: <color=red>" + EnemyManager.instance.enemyCount.ToString();
    }

}
