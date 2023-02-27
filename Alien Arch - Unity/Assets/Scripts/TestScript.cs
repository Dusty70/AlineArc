using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessege;
    public string otherMessege;

    public string[] messages;

    public int messageChoice;

    public string message1;
    public string message2;
    public string message3;


    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning(startMessege);
        Debug.Log("I would throw roten fruit at you but it would be a waste of resorces");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("you dont deserv to like your self");
        Debug.Log(otherMessege);
        Debug.Log("you are a waste of space time");

        //messageChoice = Random.Range(1, 4);
        /*
        if (messageChoice == 1)
        {
            Debug.Log(messages[0]);
        }
        else if (messageChoice == 0)
        {
            Debug.Log("you fool cant you count give me a number");
        }
        else if (messageChoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (messageChoice == 3)
        {
            Debug.Log(messages[2]);
        }
        else if (messageChoice == 4)
        {
            Debug.Log("you idiet the dialog options dont go that high");
        }
        else
        {
            Debug.Log("you moron that isent a valid message choice");
        }
        */
        
        if (messages.Length > messageChoice && messageChoice >= 0 )
        {
            Debug.Log(messages[messageChoice]);
        }
        else
        {
            Debug.Log("you ideit you entered a number to high are you iliteret or sumthing");
        }
    }
}
