using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D centerBody;
    [SerializeField] private float jumpForce;
    [SerializeField] private float playerSpeed;
    [SerializeField] private Vector2 jumpHeight;
    [SerializeField] private float positionRadius;
    [SerializeField] private Transform playerPos;
    [SerializeField] private LayerMask layerMask;
    private Animator animator;
    [SerializeField] private bool isOnGround;
    private bool isJumping = false;
    private Vector2 moveDirection = Vector2.zero;
    

    private void Awake()
    {
        animator = GetComponent<Animator>();

        
    }

    private void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.Play("WalkRight");
            moveDirection = Vector2.right;
        }
        else if(Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.Play("WalkLeft");
            moveDirection = Vector2.left;
        }
        else
        {
            animator.Play("Idle");
            moveDirection = Vector2.zero;
        }

        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, layerMask);
        print(Physics2D.OverlapCircle(playerPos.position, positionRadius, layerMask));
        print(positionRadius);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isOnGround)
            {
                isJumping = true;
            }
        }
    }

    private void FixedUpdate()
    {
        if(isJumping)
        {
            centerBody.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
            isJumping = false;
        }

        centerBody.AddForce(moveDirection * playerSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
