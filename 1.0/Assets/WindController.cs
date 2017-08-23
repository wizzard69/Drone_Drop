using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour {

    //enum WindDirection { Left, Right };

    public float windSpeed;

    Rigidbody rb;
    bool windForce = false;
    int direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            windForce = !windForce;
            direction = Random.Range(0, 2);
        }

        StartWindForce();
	}

    private void StartWindForce()
    {
        if (windForce)
        {
            if (direction == 0)
            {
                rb.AddForce(windSpeed, 0, 0, ForceMode.Force);
            }
            else
            {
                rb.AddForce(-windSpeed, 0, 0, ForceMode.Force);
            }

        }
    }
}
