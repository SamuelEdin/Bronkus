using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    [SerializeField] GameObject Player;
    private Management manager;

    [SerializeField] string Color;

    public Vector2 teleportCoordinates; //field where I put desired coordinates

    private void Start()
    {
        manager = Player.GetComponent<Management>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //check if player collides with box collider of door
        if (other.CompareTag("Player") && manager.pickedUpKeys.Contains(Color))
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
