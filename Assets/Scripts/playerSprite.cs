using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerSprite : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;

    [SerializeField] private GameObject faceSprite;
    [SerializeField] private GameObject colorSprite;

    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();

        GameObject dontdestroy = GameObject.Find("PlayerImage");

        Transform face = dontdestroy.transform.GetChild(0);
        Transform color = dontdestroy.transform.GetChild(1);

        Image faceImage = face.GetComponent<Image>();
        Image colorImage = color.GetComponent<Image>();
        Image theImage = dontdestroy.GetComponent<Image>();

        face.SetParent(transform);
        color.SetParent(transform);

        //playerSpriteRenderer.sprite = faceImage.sprite;
        //playerSpriteRenderer.sprite = bodyImage.sprite;
        //playerSpriteRenderer.sprite = theImage.sprite;
       
    }
}
