using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    private Slider alertBar;
    [SerializeField] private float alertLimit = 50000;

    private void Start()
    {
        GameObject inGameUI = GameObject.Find("InGameUI");
        alertBar = inGameUI.transform.Find("AlertBar").GetComponent<Slider>();

        /*Text timerText = inGameUI.transform.Find("Timer").Find("TimerText").gameObject.GetComponent<Text>();*/

        alertBar.maxValue = alertLimit;
        alertBar.value = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //Reload the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddAlertBar(float alertValue)
    {
        alertBar.value += alertValue;
        if(alertBar.value >= alertBar.maxValue)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
