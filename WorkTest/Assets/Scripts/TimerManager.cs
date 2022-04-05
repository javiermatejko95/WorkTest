using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private float timer = 20f;
    #endregion

    #region PRIVATE_FIELDS
    private bool on = false;
    private GameActions gameActions = null;
    private Action<int> OnTimerUpdate = null;
    #endregion

    #region UNITY_CALLS
    private void Update()
    {
        if(on)
        {
            timer -= Time.deltaTime;
                        
            OnTimerUpdate?.Invoke((int)timer);
            
            if(timer <= 0f)
            {
                gameActions.OnGameEnd?.Invoke(true);
                SetTimer(false);
            }
        }
    }
    #endregion

    #region PUBLIC_METHODS
    public void Init(GameActions gameActions, Action<int> OnTimerUpdate)
    {
        this.gameActions = gameActions;
        this.OnTimerUpdate = OnTimerUpdate;
        this.OnTimerUpdate?.Invoke((int)timer);
    }

    public void SetTimer(bool state)
    {
        on = state;
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
