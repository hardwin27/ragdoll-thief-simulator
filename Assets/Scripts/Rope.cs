using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] private Transform ropeAnchor;
    [SerializeField] private bool isMoving = false;
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

        Vector3 targetPos = (isMoveToMax) ? maxPosition : minPosition;
        ropeAnchor.transform.localPosition = Vector3.MoveTowards(ropeAnchor.transform.localPosition, targetPos, moveSpeed * Time.deltaTime);
        if(Vector2.Distance(ropeAnchor.transform.localPosition, targetPos) <= 0.2)
        {
            isMoveToMax = !isMoveToMax;
        }
    }
}
