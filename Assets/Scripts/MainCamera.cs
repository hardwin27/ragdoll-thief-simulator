using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private static MainCamera mainCameraInstance;
    private void Awake()
    {
        /*if (mainCameraInstance == null)
        {
            mainCameraInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (mainCameraInstance != this)
        {
            Destroy(gameObject);
        }*/
    }
}
