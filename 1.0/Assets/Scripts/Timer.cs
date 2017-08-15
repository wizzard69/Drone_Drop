using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float startTime;

    public Image timerBar;

	private float currentTime;

	private bool stop = false;

	private float mins;
	private float secs;


	void Start()
	{
		currentTime = startTime;

        timerBar.fillAmount = 1f;
	}

	void Update()
	{
		if (stop) return;

		currentTime -= Time.deltaTime;

		mins = Mathf.Floor (currentTime / 60);
		secs = currentTime % 60;

		if (secs > 59) {
			secs = 59;
		}

        if (mins < 0)
        {
            stop = true;
            mins = 0;
            secs = 0;
        }

		timerBar.fillAmount = currentTime / startTime;
	}
}
