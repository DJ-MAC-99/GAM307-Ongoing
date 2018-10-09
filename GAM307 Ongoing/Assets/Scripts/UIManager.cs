using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour {

    public TextMeshProUGUI enemyCountText;
    public TextMeshProUGUI scoreText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        enemyCountText.text = "Enemy Count" + " - " + EnemyManager.instance.enemyCount.ToString();
        scoreText.text = "Score" + " - " + GameManager.instance.scoreTotal.ToString();

	}
}
