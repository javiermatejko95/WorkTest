using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private float movingSpeed = 10f;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    private void Awake()
    {

    }
    #endregion

    #region PUBLIC_METHODS
    public void Move(float movingAxis)
    {
        transform.position += new Vector3(movingAxis, 0f, 0f) * movingSpeed * Time.deltaTime;
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
