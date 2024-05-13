using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] int Boost;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.GetComponent<Movement>().moveSpeed = Boost;
        }
    }
}
