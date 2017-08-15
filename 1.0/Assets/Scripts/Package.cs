using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour {

    //private Vector3 offset;
	private FixedJoint fixedjoint;
	public bool connected;

	void Start()
	{
		connected = false;
	}

    private void OnTriggerEnter(Collider collision)
    {
		if (collision.transform.tag == "Player")
		{
			connected = true;

			fixedjoint = gameObject.AddComponent<FixedJoint>();

            fixedjoint.connectedBody = collision.GetComponentInParent<Rigidbody> ();
		}
	}

    private void Update()
	{
        if (!connected)
        {
			Destroy (fixedjoint);
        }
    }
}
