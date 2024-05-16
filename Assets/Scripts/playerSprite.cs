using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class playerSprite : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;

    private void Start()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();

        GameObject dontdestroy = GameObject.Find("PlayerImage");

        Transform face = dontdestroy.transform.GetChild(0);
        Transform body = dontdestroy.transform.GetChild(1);

        Image faceImage = face.GetComponent<Image>();
        Image bodyImage = body.GetComponent<Image>();
        Image theImage = dontdestroy.GetComponent<Image>();

 
        face.SetParent(transform);
        body.SetParent(transform);

        playerSpriteRenderer.sprite = faceImage.sprite;
        playerSpriteRenderer.sprite = bodyImage.sprite;
        playerSpriteRenderer.sprite = theImage.sprite;

       
    }
}
