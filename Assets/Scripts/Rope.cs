using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    private enum MoveDirection
    {
        Horizontal,
        Vertical
    }

    /*[SerializeField] private Transform ropeAnchor;*/
    [SerializeField] private Rigidbody2D ropeAnchorBody;
    [SerializeField] private bool isMoving = false;
    [SerializeField] private MoveDirection moveDirection = MoveDirection.Horizontal;
    [SerializeField] private Vector3 minPosition;
    [SerializeField] private Vector3 maxPosition;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isMoveToMax = true;


    private void Update()
    {
        if(!isMoving)
        {
            return;
        }

        /*ropeAnchor.transform.localPosition = Vector3.MoveTowards(ropeAnchor.transform.localPosition, targetPos, moveSpeed * Time.deltaTime);
        if (Vector2.Distance(ropeAnchor.transform.localPosition, targetPos) <= 0.2)
        {
            isMoveToMax = !isMoveToMax;
        }*/
    }

    private void FixedUpdate()
    {
        if (!isMoving)
        {
            return;
        }

        Vector3 targetPos = (isMoveToMax) ? maxPosition : minPosition;
        float speed = (isMoveToMax) ? moveSpeed : -moveSpeed;
        Vector2 velocity = (moveDirection == MoveDirection.Horizontal) ?
            new Vector2(speed * Time.fixedDeltaTime, 0f) :
            new Vector2(0f, speed * Time.fixedDeltaTime);

        ropeAnchorBody.velocity = velocity;
        if (Vector2.Distance(ropeAnchorBody.gameObject.transform.localPosition, targetPos) <= 0.2)
        {
            isMoveToMax = !isMoveToMax;
        }
    }
}
