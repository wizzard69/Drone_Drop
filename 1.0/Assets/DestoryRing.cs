using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryRing : MonoBehaviour {


    private void DestroyRingNow()
    {
        
        Destroy(transform.parent.gameObject);
    }
}
