using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private UIController uiController = null;
    #endregion

    #region PRIVATE_FIELDS
    private int coins = 0;
    #endregion

    #region UNITY_CALLS

    #endregion

    #region PUBLIC_METHODS
    public void Init(GameActions gameActions)
    {
        gameActions.OnCoinPickedUp += OnPickedUpCoin;
        gameActions.OnCoinPickedUp?.Invoke(coins);
    }
    #endregion

    #region PRIVATE_METHODS
    private void OnPickedUpCoin(int amount)
    {
        coins += amount;
        uiController.UpdateCoinsText(coins);
    }
    #endregion
}
