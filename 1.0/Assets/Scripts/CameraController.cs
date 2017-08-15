using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform dronePlayer;
    public Vector3 offset;
    public float smoothSpeed;

    private Vector3 desiredPosition;

    // Use this for initialization
    void Start()
    {
        dronePlayer = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        ///Trial
        desiredPosition = dronePlayer.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        transform.LookAt(dronePlayer);
        ///
    }
}
