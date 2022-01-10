using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField] private Text endTimeText;

    void Start()
    {
        //Copy the total time passed to the EndScene timer label
        //Tben destroy the InGameUi, which contain the timer, when player reach the end screen
        /*GameObject inGameUI = GameObject.Find("InGameUI");
        Text timerText = inGameUI.transform.Find("Timer").Find("TimerText").gameObject.GetComponent<Text>();

        endTime.text = timerText.text;

        Destroy(inGameUI);*/
    }
}
