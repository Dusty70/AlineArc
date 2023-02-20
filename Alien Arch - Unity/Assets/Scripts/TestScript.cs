using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessege;
    public string otherMessege;


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
    }
}
