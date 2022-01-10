using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    [SerializeField] private Text timerText;
    private TimeSpan timePlaying;
    private bool isTimerOn;
    private float timePassed;

    private void Start()
    {
        // timerText.text = "00:00.00";
        isTimerOn = false;
        BeginTimer();
    }

    private void BeginTimer()
    {
        isTimerOn = true;
        timePassed = 0.0f;

        StartCoroutine(UpdateTimer());
    }

    private void EndTimer()
    {
        isTimerOn = false;
    }

    //Update the timer 
    IEnumerator UpdateTimer()
    {
        while (isTimerOn)
        {
            timePassed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timePassed);
            string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
            timerText.text = timePlayingStr;

            yield return null;
        }
    }
}
