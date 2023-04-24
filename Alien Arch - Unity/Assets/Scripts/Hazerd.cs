using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazerd : MonoBehaviour
{
    // thi is the damege of hazerds
    public int Hazard;


    //built in unity function for handeling collisions
    // will hapen on collision
    void OnCollisionEnter2D(Collision2D collisonData)
    {
        //get the object collided with
        Collider2D ObjectWeCollideWith = collisonData.collider;

        //get player health
        PlayerHealth player = ObjectWeCollideWith.GetComponent<PlayerHealth>();
        
        //check if player
        if (player != null)
        {
            player.ChangeHealth(-Hazard);
        }
    }

}
