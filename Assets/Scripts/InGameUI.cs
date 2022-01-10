using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : MonoBehaviour
{
    private static InGameUI inGameUiInstance;
    private void Awake()
    {
        /*DontDestroyOnLoad(gameObject);

        if (inGameUiInstance == null)
        {
            inGameUiInstance = this;
        }
        else
        {
            Destroy(inGameUiInstance.gameObject);
        }*/

        if(inGameUiInstance == null)
        {
            inGameUiInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(inGameUiInstance != this)
        {
            Destroy(gameObject);
        }
    }
}
