using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameEvents {

    //Event Variables
    public static event Action OnEnemyDie = null;
    public static event Action<GameState> OnGameStateChange = null;
    public static event Action<Difficulty> OnDifficultyChange = null;


    //Event Happenings
    public static void ReportOnEnemyDie()
    {
        if (OnEnemyDie != null)
            OnEnemyDie();
    }
    
    public static void ReportOnGameStateChange(GameState gs)
    {
        if (OnGameStateChange != null)
            OnGameStateChange(gs);
    }
    
    public static void ReportOnDifficultyChange(Difficulty difficulty)
    {
        if (OnDifficultyChange != null)
            OnDifficultyChange(difficulty);
    }

    
    static void Log(string msg)
    {
        Debug.Log(msg);
    }
	
}
