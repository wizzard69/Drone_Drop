using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour {

    public float InvokeStartTime = 1.0f;
    public float InvokeReapeat = 3.0f;

    private void Start()
    {
		InvokeRepeating("GetRing", InvokeStartTime, InvokeReapeat);
    }

    void GetRing()
    {
        Instantiate((GameObject)Resources.Load("Ring"), transform.position, Quaternion.identity);
    }
}
