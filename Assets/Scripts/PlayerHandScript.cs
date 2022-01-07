using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandScript : MonoBehaviour
{
    private bool isHolding;
    private FixedJoint2D tempJoint;
    [SerializeField] private KeyCode usedMouseButton;

    private void Update()
    {
        if (Input.GetKey(usedMouseButton))
        {
            isHolding = true;

        }
        else
        {
            isHolding = false;
            Destroy(tempJoint);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isHolding)
        {
            Rigidbody2D collidedBody = collision.transform.GetComponent<Rigidbody2D>();
            if(collidedBody != null)
            {
                tempJoint = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
                tempJoint.connectedBody = collidedBody;
            }
            else
            {
                tempJoint = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
            }
        }
    }
}
