using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobe : MonoBehaviour
{
    public Light RedLight;
    public Light greenLight;
    public int Number = 1;

    // Use this for initialization
    void Start()
    {
        Number = 1;
        greenLight.GetComponent<Light>().intensity = 0;
        RedLight.GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Number == 1)
        {
            greenLight.GetComponent<Light>().intensity = 0;
            RedLight.GetComponent<Light>().intensity = 1.5f;
            StartCoroutine(waitforred());
        }
        if (Number == 2)
        {
            greenLight.GetComponent<Light>().intensity = 1.5f;
            RedLight.GetComponent<Light>().intensity = 0;
            StartCoroutine(waitforblue());
        }
    }

    IEnumerator waitforred()
    {
        yield return new WaitForSeconds(0.5f);
        Number = 2;
    }

    IEnumerator waitforblue()
    {
        yield return new WaitForSeconds(0.5f);
        Number = 1;
    }
}
