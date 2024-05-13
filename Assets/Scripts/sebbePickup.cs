using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using TMPro;

public class sebbePickup : MonoBehaviour
{
    [SerializeField] string id;
    [SerializeField] GameObject Player;
    private Management manager;

    [SerializeField] private GameObject sebbeTextbox;
    private void Start()
    {
        manager = Player.GetComponent<Management>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            manager.addSebbe(id);
            sebbeTextbox.GetComponent<TextMeshProUGUI>().text = manager.pickedSebbes.Count.ToString() + " / 6";
            Destroy(gameObject);
        }
    }

}
