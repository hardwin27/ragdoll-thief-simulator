using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    private static BgmManager bgmManagerInstance;
    private void Awake()
    {
        if (bgmManagerInstance == null)
        {
            bgmManagerInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (bgmManagerInstance != this)
        {
            Destroy(gameObject);
        }
    }
}
