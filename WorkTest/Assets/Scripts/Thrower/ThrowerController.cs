using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private RockSpawner rockSpawner = null;
    [SerializeField] private ThrowerAnimationController throwerAnimationController = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS

    #endregion

    #region PUBLIC_METHODS
    public void Init()
    {
        rockSpawner.Init(throwerAnimationController.SetAnimation, throwerAnimationController.SetAnimation);
    }

    public void SetRockSpawnerOn(bool state)
    {
        rockSpawner.SetOn(state);
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
