using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovement : MonoBehaviour
{
    #region EXPOSED_FIELDS
    [SerializeField] private Vector3[] points = null;
    [SerializeField] private float range = 2f;
    #endregion

    #region PRIVATE_FIELDS
    private Transform floorPosition = null;
    private float time = 0f;
    private float height = 2f;
    private bool bounced = false;
    #endregion

    #region UNITY_CALLS
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            StopCoroutine(NextPoint());
            CalculateRoute();
            StartCoroutine(NextPoint());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Spring")
        {
            bounced = true;
            StartMoving();
        }
    }
    #endregion

    #region PUBLIC_METHODS
    public void Init(Transform floorPosition)
    {
        this.floorPosition = floorPosition;
    }

    public void StartMoving()
    {
        StopCoroutine(NextPoint());
        CalculateRoute();
        time = 0f;
        StartCoroutine(NextPoint());
    }
    #endregion

    #region PRIVATE_METHODS
    private IEnumerator NextPoint()
    {
        while (time < 1f)
        {
            time += Time.deltaTime;

            this.transform.position = Mathf.Pow(1 - time, 3) * points[0] +
                3 * Mathf.Pow(1 - time, 2) * time * points[1] +
                3 * (1 - time) * Mathf.Pow(time, 2) * points[2] +
                Mathf.Pow(time, 3) * points[3];

            yield return new WaitForEndOfFrame();
        }

        time = 0f;
        Destroy(this.gameObject);
    }

    private void CalculateRoute()
    {
        if(!bounced)
        {
            height = range / 2;
        }
        
        points[0] = this.transform.position;
        points[1] = points[0] + Vector3.right + Vector3.up * height;
        points[2] = points[1] + Vector3.right * range;
        points[3] = points[2] + Vector3.right * 2f;
        points[3].y = floorPosition.position.y;
    }
    #endregion
}
