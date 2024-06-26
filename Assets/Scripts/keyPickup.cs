using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPickup : MonoBehaviour
{
    [SerializeField] string Color;
    [SerializeField] GameObject Player;
    private Management manager;

    [SerializeField] private GameObject keyIcon;

    private void Start()
    {
        manager = Player.GetComponent<Management>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            manager.addKey(Color);
            keyIcon.SetActive(true);
            Destroy(gameObject);
        }
    }
}
