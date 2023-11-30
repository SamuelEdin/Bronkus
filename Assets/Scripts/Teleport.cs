using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector2 teleportCoordinates; //set coords in unity

    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if player collides
        if (other.CompareTag("Player"))
        {
            TeleportPlayer(other.transform);
        }
    }

    void TeleportPlayer(Transform playerTransform)
    {
        //teleport player
        playerTransform.position = teleportCoordinates;
    }
}
