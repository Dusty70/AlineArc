using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MobilePlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;        // The speed at which the character moves.
    public float jumpForce = 10f;       // The force applied to the character when jumping.
    public Transform groundCheck;      // A reference to an empty GameObject at the character's feet.
    public LayerMask groundLayer;      // The layer used for the ground.

    private Rigidbody2D rb2d;          // Reference to the Rigidbody2D component.
    private bool isGrounded;           // Is the character grounded?
    private bool isJumping;            // Is the character currently jumping?

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if the character is grounded.
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Left movement when LeftButton is pressed.
        if (Input.GetButton("LeftButton"))
        {
            Move(-1);
        }

        // Right movement when RightButton is pressed.
        if (Input.GetButton("RightButton"))
        {
            Move(1);
        }

        // Jump when JumpButton is pressed and the character is grounded.
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    private void Move(float direction)
    {
        // Calculate the movement velocity.
        Vector2 moveVelocity = new Vector2(direction * moveSpeed, rb2d.velocity.y);
        rb2d.velocity = moveVelocity;
    }

    private void Jump()
    {
        // Apply upward force for jumping.
        rb2d.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isJumping = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset jump state when landing after a jump.
        if (collision.gameObject.layer == groundLayer)
        {
            isJumping = false;
        }
    }
}