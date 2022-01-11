using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager _instance = null;
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<AudioManager>();
            }
            return _instance;
        }
    }

    private AudioSource bumpSfx;

    private void Awake()
    {
        bumpSfx = GetComponent<AudioSource>();
    }

    public void PlaySfx()
    {
        bumpSfx.Play();
    }
}
