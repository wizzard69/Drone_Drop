using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Battery : MonoBehaviour {

    public float startCharge;
    public float dechargeRate;
    public float loadedDechargerate;
    public float rechargeRate;
    public float currentCharge;
    //public Text batteryText;

    private void Start()
    {
        currentCharge = startCharge;
    }

    private void Update()
    {
        if (currentCharge <= 0)
        {
            print("Battery Dead!!");
            currentCharge = 0;
        }
    }
}
