using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.relativeVelocity.sqrMagnitude);
    }
}
