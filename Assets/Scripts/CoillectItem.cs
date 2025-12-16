using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoillectItem : MonoBehaviour
{

    private int collectibles = 0;

    [SerializeField] private Text collectiblesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            collectibles++;
            collectiblesText.text = "Collectibles: " + collectibles;
        }
    }

}
