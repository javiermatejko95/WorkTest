using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private GameObject coinPrefab = null;
    [SerializeField] private float interval = 1f;
    [SerializeField] private Transform playerTarget = null;
    [SerializeField] private Transform leftLimit = null;
    [SerializeField] private Transform rightLimit = null;
    [SerializeField] private Transform floorPosition = null;
    #endregion

    #region PRIVATE_FIELDS
    private float currentTimer = 0f;
    private GameActions gameActions = null;
    private bool on = false;
    #endregion

    #region UNITY_CALLS
    private void Update()
    {
        if(!on)
        {
            return;
        }
        if (currentTimer >= interval)
        {
            SpawnCoin();
            currentTimer = 0f;
        }
        else
        {
            currentTimer += Time.deltaTime;
        }
    }
    #endregion

    #region PUBLIC_METHODS
    public void Init(GameActions gameActions)
    {
        this.gameActions = gameActions;
    }

    public void SetOn(bool state)
    {
        this.on = state;
    }
    #endregion

    #region PRIVATE_METHODS
    private void SpawnCoin()
    {
        //TODO coin pool
        GameObject go = Instantiate(coinPrefab, this.transform);
        go.GetComponent<Coin>().Init(gameActions);
        SetCoinPosition(go.transform);
    }

    private void SetCoinPosition(Transform coin)
    {
        Vector2 newPos = new Vector2(Random.Range(leftLimit.position.x, rightLimit.position.x), floorPosition.position.y);
        coin.position = newPos;
    }
    #endregion
}
