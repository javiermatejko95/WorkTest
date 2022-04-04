using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private Transform playerTarget = null;
    [SerializeField] private Transform leftLimit = null;
    [SerializeField] private Transform rightLimit = null;
    #endregion

    #region PRIVATE_FIELDS
    private Camera camera = null;
    private float cameraWidth = 0f;
    #endregion

    #region UNITY_CALLS
    private void Awake()
    {
        this.camera = Camera.main;
        cameraWidth = camera.orthographicSize * camera.aspect;
    }

    private void Update()
    {
        this.transform.position = new Vector3(
            Mathf.Clamp(playerTarget.position.x, leftLimit.position.x + cameraWidth, rightLimit.position.x - cameraWidth),
            transform.position.y, 
            transform.position.z);
    }
    #endregion

    #region PUBLIC_METHODS

    #endregion

    #region PRIVATE_METHODS

    #endregion
}
