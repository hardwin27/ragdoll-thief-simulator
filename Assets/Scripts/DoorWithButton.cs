using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorWithButton : MonoBehaviour
{
    [SerializeField] private InteractButton[] interactBttns;
    private float bttnHoldDuration = 3f;
    private int interactBttnAmount;
    private int pressedBttnAmount = 0;
    private float bttnHoldTimer;

    private void Start()
    {
        interactBttnAmount = interactBttns.Length;

        foreach(InteractButton button in interactBttns)
        {
            button.OnPressed = () =>
            {
                pressedBttnAmount += 1;
            };

            button.OnReleased = () =>
            {
                pressedBttnAmount -= 1;
            };
        }

        ResetTimer();
    }

    private void Update()
    {
        if (gameObject.activeSelf)
        {
            if (pressedBttnAmount == interactBttnAmount)
            {
                bttnHoldTimer -= Time.deltaTime;
                if (bttnHoldTimer <= 0f)
                {
                    gameObject.SetActive(false);
                }
            }
            else
            {
                ResetTimer();
            }
        }
    }

    private void ResetTimer()
    {
        bttnHoldTimer = bttnHoldDuration;
    }
}
