using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hole : MonoBehaviour
{
    // pblic variables editable in unity
    public string targetScene = "you blob fish";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // CONDITION 2
        if (collision.CompareTag("Player"))
        ChangeScene();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);

    }
}
