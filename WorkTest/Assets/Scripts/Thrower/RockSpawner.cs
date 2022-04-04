using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private GameObject rockPrefab = null;
    [SerializeField] private Transform spawnPosition = null;
    [SerializeField] private Transform floorPosition = null;
    #endregion

    #region PRIVATE_FIELDS
    private float interval = 1f;
    private float currentTimer = 0f;
    private bool on = false;
    #endregion

    #region UNITY_CALLS
    private void Update()
    {
        if(currentTimer >= interval)
        {
            SpawnRock();
            currentTimer = 0f;
        }
        else
        {
            currentTimer += Time.deltaTime;
        }
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS
    private void SpawnRock()
    {
        GameObject go = Instantiate(rockPrefab, spawnPosition);
        go.transform.position = this.transform.position;
        RockMovement rock = go.GetComponent<RockMovement>();
        rock.Init(floorPosition);
        rock.StartMoving();
    }
    #endregion
}
