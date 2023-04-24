using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //starting health
    public int startingHealth;

    // this is the curent health
    int currentHealth;

    //built in unity function
    //this happens before the start()
    void Awake()
    {
        // initulise our current health
        currentHealth = startingHealth;
    }

    //not built into unity
    // change player health
    public void ChangeHealth(int changeAmount)
    {
        // change current health
        currentHealth = currentHealth + changeAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        //if our health drops to 0 die
        if(currentHealth == 0)
        {
            Kill();
        }
    }


    // this function is not built into unity
    // it wil be called manualy by our own code
    // it must be marked public so our other scripts can acses it
    public void Kill()
    {
        //destroy object game obgect atached
        Destroy(gameObject);
    }

    //geter function to give health value to other code
    public int GetHealth()
    {
        return currentHealth;
    }


}
