using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalObject : MonoBehaviour
{
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        float addValue = Mathf.Clamp(collision.relativeVelocity.sqrMagnitude, 0, 5000);
        GameManager.Instance.AddAlertBar(addValue);
    }
}
