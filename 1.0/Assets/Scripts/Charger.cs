using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charger : MonoBehaviour {

    public Battery battery;
    public bool isCharging = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            isCharging = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isCharging = false;
    }
    private void Update()
    {
        if (isCharging)
        {
            if (battery.currentCharge < battery.startCharge)
            {
                battery.currentCharge += battery.rechargeRate * Time.deltaTime;
            }
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 80 && (battery.currentCharge / battery.startCharge) * 100 < 100)
        {

            BatteryStatus.instance.ChangeBatteryStatus(5);
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 60 && (battery.currentCharge / battery.startCharge) * 100 < 80)
        {
            BatteryStatus.instance.ChangeBatteryStatus(4);
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 40 && (battery.currentCharge / battery.startCharge) * 100 < 60)
        {
            BatteryStatus.instance.ChangeBatteryStatus(3);
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 20 && (battery.currentCharge / battery.startCharge) * 100 < 40)
        {
            BatteryStatus.instance.ChangeBatteryStatus(2);
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 10 && (battery.currentCharge / battery.startCharge) * 100 < 20)
        {
            BatteryStatus.instance.ChangeBatteryStatus(1);
        }

        if ((battery.currentCharge / battery.startCharge) * 100 >= 0 && (battery.currentCharge / battery.startCharge) * 100 < 10)
        {
            BatteryStatus.instance.ChangeBatteryStatus(0);
        }
    }


}
