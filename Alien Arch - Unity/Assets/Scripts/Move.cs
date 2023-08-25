using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Move : MonoBehaviour
{
    //reference to a ridgedbody2Dcomponment
    private Rigidbody2D shermen = null;
    public Collider2D GroundSensor = null;
    private bool isJumping;
    public LayerMask GroundLayer = 0;

    public void moveleft()
    {
        Vector2 newVelcity = shermen.velocity;
        newVelcity.x = -5;
        shermen.velocity = newVelcity;
    }

    public float jumpSpeed = 10;
    public float Speed = 5;

    public void jump()
    {
        if (GroundSensor.IsTouchingLayers(GroundLayer))
        {

            Vector2 newVelcity = shermen.velocity;
            newVelcity.y = jumpSpeed;
            shermen.velocity = newVelcity;
        }
    }


    public void moveright()
    {
            Vector2 newVelcity = shermen.velocity;
            newVelcity.x = 5;
            shermen.velocity = newVelcity;
    }



    private void Awake()
    {
        shermen = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Reset jump state when landing after a jump.
        if (collision.gameObject.layer == GroundLayer)
        {
            isJumping = false;
        }
        else
        {
            isJumping = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
