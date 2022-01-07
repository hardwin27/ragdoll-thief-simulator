using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmController : MonoBehaviour
{
    [SerializeField] private KeyCode usedMouseButton;

    private int armSpeed = 300;
    private Rigidbody2D armBody;
    private Camera mainCam;
    private bool isArmMoving = false;
    private float armRotation;

    private void Awake()
    {
        armBody = GetComponent<Rigidbody2D>();
        mainCam = Camera.main;
    }

    private void Update()
    {
        Vector3 aimedPos = new Vector3(mainCam.ScreenToWorldPoint(Input.mousePosition).x, mainCam.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z);
        Vector3 posDiff = aimedPos - transform.position;
        armRotation = Mathf.Atan2(posDiff.x, -posDiff.y) * Mathf.Rad2Deg;
        isArmMoving = Input.GetKey(usedMouseButton);
    }

    private void FixedUpdate()
    {
        if(isArmMoving)
        {
            armBody.MoveRotation(Mathf.LerpAngle(armBody.rotation, armRotation, armSpeed * Time.fixedDeltaTime));
        }
    }
}
