using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NewBehaviourScript : MonoBehaviour
{
    //reference to a ridgedbody2Dcomponment
    private Rigidbody2D shermen = null;

    public void moveleft()
    {
        Vector2 newVelcity = shermen.velocity;
        newVelcity.x = -Speed;
        shermen.velocity = newVelcity;
    }

    public float jumpSpeed = 10;
    public float Speed = 5;

    public void jump()
    {
        Vector2 newVelcity = shermen.velocity;
        newVelcity.y = jumpSpeed;
        shermen.velocity = newVelcity;
    }


    public void moveright()
    {
        Vector2 newVelcity = shermen.velocity;
        newVelcity.x = Speed;
        shermen.velocity = newVelcity;
    }



    private void Awake()
    {
        shermen = GetComponent<Rigidbody2D>();
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
