using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    [SerializeField] private Slider alertBar;
    private float alertLimit = 50000;

    private void Start()
    {
        alertBar.maxValue = alertLimit;
        alertBar.value = 0;
    }

    public void AddAlertBar(float alertValue)
    {
        alertBar.value += alertValue;
    }
}
