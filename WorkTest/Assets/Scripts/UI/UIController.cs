using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private TextMeshProUGUI rocksText = null;
    [SerializeField] private TextMeshProUGUI timerText = null;
    [SerializeField] private TextMeshProUGUI coinsText = null;
    #endregion

    #region PUBLIC_ACTIONS
    public Action<int> OnTimerUpdate = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    private void Awake()
    {

    }
    #endregion

    #region PUBLIC_METHODS
    public void Init()
    {
        OnTimerUpdate += UpdateTimerText;
    }

    public void UpdateRocksText(int amount)
    {
        rocksText.text = "x" + amount.ToString();
    }

    public void UpdateCoinsText(int amount)
    {
        coinsText.text = "x " + amount.ToString();
    }
    #endregion

    #region PRIVATE_METHODS
    private void UpdateTimerText(int time)
    {
        timerText.text = "TIME " + time.ToString();
    }
    #endregion
}
