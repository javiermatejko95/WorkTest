using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowerAnimationController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private Animator anim = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    private void Update()
    {

    }
    #endregion

    #region PUBLIC_METHODS
    public void SetAnimation(bool state)
    {
        anim.SetBool("throwing", state);
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
