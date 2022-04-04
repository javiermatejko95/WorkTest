using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    #region EXPOSED_FIELDS

    #endregion

    #region PUBLIC_ACTIONS

    #endregion

    #region PRIVATE_FIELDS
    private GameActions gameActions = null;
    #endregion

    #region UNITY_CALLS
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameActions.OnCoinPickedUp?.Invoke(1);
            Destroy(this.gameObject);
        }
    }
    #endregion

    #region PUBLIC_METHODS
    public void Init(GameActions gameActions)
    {
        this.gameActions = gameActions;
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
