using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    //variables refrencing in game objects
    TMP_Text healthValue;
    PlayerHealth player;



    // Start is called before the first frame update
    void Start()
    {
        //store in variable
        healthValue = GetComponent<TMP_Text>();
        //serch entire scene for player health
        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        //get current health value from player
        healthValue.text = player.GetHealth().ToString();


    }
}
