using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameActions
{
    public Action<int> OnRockReachedGoal = null;
    public Action<int> OnCoinPickedUp = null;
    public Action<bool> OnGameEnd = null;
}

public class GameManager : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private UIController uiController = null;
    [SerializeField] private ScoreManager scoreManager = null;
    [SerializeField] private CoinController coinController = null;
    [SerializeField] private TimerManager timerManager = null;
    #endregion

    #region PRIVATE_FIELDS
    private GameActions gameActions = new GameActions();
    #endregion

    #region UNITY_CALLS
    private void Awake()
    {
        gameActions.OnGameEnd += EndGame;

        scoreManager.Init(gameActions);
        coinController.Init(gameActions);
        uiController.Init();
        timerManager.Init(gameActions, uiController.OnTimerUpdate);
        timerManager.SetTimer(true);
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS
    private void EndGame(bool state)
    {
        if(state)
        {

        }
    }
    #endregion
}
