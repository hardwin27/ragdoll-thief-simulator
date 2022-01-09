using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalObject : MonoBehaviour
{
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.AddAlertBar(collision.relativeVelocity.sqrMagnitude);
    }
}
