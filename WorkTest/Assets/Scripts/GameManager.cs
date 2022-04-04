using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameActions
{
    public Action<int> OnRockReachedGoal = null;
    public Action<int> OnCoinPickedUp = null;
}

public class GameManager : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private UIController uiController = null;
    [SerializeField] private ScoreManager scoreManager = null;
    [SerializeField] private CoinController coinController = null;
    #endregion

    #region PUBLIC_ACTIONS

    #endregion

    #region PRIVATE_FIELDS
    private GameActions gameActions = new GameActions();
    #endregion

    #region UNITY_CALLS
    private void Awake()
    {
        scoreManager.Init(gameActions);
        coinController.Init(gameActions);
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS

    #endregion
}
