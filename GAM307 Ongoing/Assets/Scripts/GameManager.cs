using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    TITLE,
    INGAME,
    PAUSED,
    GAMEOVER,
}

public enum Difficulty
{
    EASY,
    MEDIUM,
    HARD,
}

public class GameManager : Singleton<GameManager>
{
    public int scoreTotal = 0;
    public GameState gameState;
    public Difficulty difficulty;

    // Use this for initialization
    void Start()
    {
        gameState = GameState.TITLE;

        difficulty = Difficulty.MEDIUM;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            difficulty = Difficulty.EASY;
            GameEvents.OnDifficultyChange;
        }
    }

    #region Scoring
    public void AddScore(int newScore)
    {
        scoreTotal += newScore;
    }
    #endregion
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
        AddScore(100);
    }
}