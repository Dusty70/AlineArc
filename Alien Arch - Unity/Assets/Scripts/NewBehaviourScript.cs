using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NewBehaviourScript : MonoBehaviour
{
    //reference to a ridgedbody2Dcomponment
    private Rigidbody2D shermen = null;



    public void moveLeft()
    {
        Vector2 newVelcity = shermen.velocity;
        newVelcity.x = 1;
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
