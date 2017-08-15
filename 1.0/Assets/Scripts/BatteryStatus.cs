using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryStatus : MonoBehaviour
{

    public static BatteryStatus instance;

    [SerializeField]
    private Color32 batteryRed;
    [SerializeField]
    private Color32 batteryOrange;
    [SerializeField]
    private Color32 batteryYellow;
    [SerializeField]
    private Color32 batteryLightGreen;
    [SerializeField]
    private Color32 batteryGreen;

    private Image battery1;
    private Image battery2;
    private Image battery3;
    private Image battery4;
    private Image battery5;

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        battery1 = transform.GetChild(0).GetComponent<Image>();
        battery2 = transform.GetChild(1).GetComponent<Image>();
        battery3 = transform.GetChild(2).GetComponent<Image>();
        battery4 = transform.GetChild(3).GetComponent<Image>();
        battery5 = transform.GetChild(4).GetComponent<Image>();

        ChangeBatteryStatus(5);
    }

    public void ChangeBatteryStatus(int defConStatus)
    {
        switch (defConStatus)
        {
            case 0:
                BatteryImageControl(false, false, false, false, false);
                BatteryImageColor(batteryGreen);
                return;
            case 1:
                BatteryImageControl(true, false, false, false, false);
                BatteryImageColor(batteryRed);
                return;
            case 2:
                BatteryImageControl(true, true, false, false, false);
                BatteryImageColor(batteryOrange);
                return;
            case 3:
                BatteryImageControl(true, true, true, false, false);
                BatteryImageColor(batteryYellow);
                return;
            case 4:
                BatteryImageControl(true, true, true, true, false);
                BatteryImageColor(batteryLightGreen);
                return;
            case 5:
                BatteryImageControl(true, true, true, true, true);
                BatteryImageColor(batteryGreen);
                return;
            default:
                BatteryImageControl(true, true, true, true, true);
                BatteryImageColor(batteryGreen);
                return;
        }
    }

    private void BatteryImageControl(bool _battery1, bool _battery2, bool _battery3, bool _battery4, bool _battery5)
    {
        battery1.enabled = _battery1;
        battery2.enabled = _battery2;
        battery3.enabled = _battery3;
        battery4.enabled = _battery4;
        battery5.enabled = _battery5;
    }

    private void BatteryImageColor(Color32 color)
    {
        battery1.color = color;
        battery2.color = color;
        battery3.color = color;
        battery4.color = color;
        battery5.color = color;
    }
}
