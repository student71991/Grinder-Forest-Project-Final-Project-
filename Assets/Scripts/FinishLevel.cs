using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{

    private bool levelCompleted1 = false;
    private bool levelCompleted2 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted1)
        {
            levelCompleted1 = true;
            Invoke("CompleteLevel1", 2f);
        }

        if (collision.gameObject.name == "Player" && !levelCompleted2)
        {
            levelCompleted2 = true;
            Invoke("CompleteLevel2", 2f);
        }

    }

    private void CompleteLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    private void CompleteLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

}
