using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private float movingSpeed = 10f;
    [SerializeField] private Transform leftLimit = null;
    [SerializeField] private Transform rightLimit = null;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS

    #endregion

    #region PUBLIC_METHODS
    public void Move(float movingAxis)
    {
        Vector3 newPos = transform.position;
        newPos += new Vector3(movingAxis, 0f, 0f) * movingSpeed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, leftLimit.position.x, rightLimit.position.x);
        transform.position = newPos;
    }
    #endregion

    #region PRIVATE_METHODS

    #endregion
}
