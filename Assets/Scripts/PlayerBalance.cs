using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    [SerializeField] private float targetRotation;
    [SerializeField] private float force;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        body.MoveRotation(Mathf.LerpAngle(body.rotation, targetRotation, force * Time.fixedDeltaTime));
    }
}
