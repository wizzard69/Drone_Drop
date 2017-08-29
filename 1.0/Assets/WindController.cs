using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindController : MonoBehaviour {

    //enum WindDirection { Left, Right };

	[Range(1, 8)]
	public float windSpeed;
    public float windDuration;

    Rigidbody rb;
    bool windForce = false;
    int direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        print(windForce); 

        if (Input.GetKeyUp(KeyCode.P))
        {
            windForce = !windForce;
            direction = Random.Range(0, 2);
        }

        if (windForce)
        {
            StartCoroutine(StartWindForce());
        }
	}

    IEnumerator StartWindForce()
    {
		if (direction == 0)
		{
			//print("Left");
			rb.AddForce(windSpeed, 0, 0, ForceMode.Force);
		}
		else
		{
			//print("Right");
			rb.AddForce(-windSpeed, 0, 0, ForceMode.Force);
		}

        yield return new WaitForSeconds(windDuration);
        windForce = false;
    }
}
