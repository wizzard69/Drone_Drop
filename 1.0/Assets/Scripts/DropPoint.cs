using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPoint : MonoBehaviour {

	public GameObject spawnpoint;

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.transform.tag == "Package")
		{
			collider.GetComponent<Package> ().connected = false;

			StartCoroutine (WaitToDestroy (collider.gameObject));
		}   
	}

	IEnumerator WaitToDestroy(GameObject packageObject)
	{
		yield return new WaitForSeconds (2f);

		Destroy (packageObject);

		Instantiate ((GameObject)Resources.Load("PackageObject"), spawnpoint.transform.position, Quaternion.identity);
	}
}
