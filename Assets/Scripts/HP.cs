using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public int currentHp;
    public int maxHp;
    public bool dead = false;

    private void Start()
    {
        currentHp = maxHp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Debug.Log("hit");
            currentHp--;
        }
        
    }
    void Update()
    {
        if (currentHp == 0) 
        {
            dead = true;
            death();
        }
    }

    public void death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
