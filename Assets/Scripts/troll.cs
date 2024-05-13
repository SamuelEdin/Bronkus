using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class troll : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if player collides with box collider of door
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
