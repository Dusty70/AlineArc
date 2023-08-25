using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    // pblic variables editable in unity
    public string targetScene = "End Screen";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // CONDITION 2
        if (collision.CompareTag("Player"))
            ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("End Screen");

    }
}

