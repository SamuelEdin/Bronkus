using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject projectile;
    public float projectileSpeed = 5f;
    public Transform spawnPoint;
    public float xPos = 18f;


    void Update()
    {
        if (Player.transform.position.x > xPos)
        {
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.velocity = -transform.up * projectileSpeed;
        }
    }

}
