using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private PlayerMovement playerMovement = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    private void FixedUpdate()
    {
        playerMovement.Move(Input.GetAxisRaw("Horizontal"));
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS

    #endregion
}
