using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private Vector3[] points = null;
    [SerializeField] private Transform floorPosition = null;
    [SerializeField] private float time = 0f;
    private float height = 2f;
    [SerializeField] private float range = 2f;
    [SerializeField] private bool canContinue = false;
    #endregion

    #region PRIVATE_FIELDS

    #endregion

    #region UNITY_CALLS
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            StopCoroutine(NextPoint());
            CalculateRoute();
            StartCoroutine(NextPoint());
        }
    }
    #endregion

    #region PUBLIC_METHODS
    private IEnumerator NextPoint()
    {
        canContinue = false;

        while(time < 1f)
        {
            time += Time.deltaTime;

            this.transform.position = Mathf.Pow(1 - time, 3) * points[0] +
                3 * Mathf.Pow(1 - time, 2) * time * points[1] +
                3 * (1 - time) * Mathf.Pow(time, 2) * points[2] +
                Mathf.Pow(time, 3) * points[3];

            yield return new WaitForEndOfFrame();
        }

        time = 0f;
    }
    #endregion

    #region PRIVATE_METHODS
    private void CalculateRoute()
    {
        height = range / 2;
        points[0] = this.transform.position;
        points[1] = points[0] + Vector3.right + Vector3.up * height;
        points[2] = points[1] + Vector3.right * range;
        points[3] = points[2] + Vector3.right * 2f;
        points[3].y = floorPosition.position.y;
    }
    #endregion
}
