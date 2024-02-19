using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speechTrigger : MonoBehaviour
{

    [SerializeField] public GameObject bubble;


    void Start()
    {
        bubble.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            bubble.SetActive(true);
        }
    }
   
   
}
