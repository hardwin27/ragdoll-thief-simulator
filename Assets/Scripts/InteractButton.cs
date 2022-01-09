using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractButton : MonoBehaviour
{
    public Action OnPressed;
    public Action OnReleased;

   private List<Collider2D> collidedObject = new List<Collider2D>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collidedObject.Count == 0)
        {
            OnPressed();
        }
        collidedObject.Add(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collidedObject.Remove(collision);
        if (collidedObject.Count == 0)
        {
            OnReleased();
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        OnPressed();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        OnReleased();
    }*/
}
