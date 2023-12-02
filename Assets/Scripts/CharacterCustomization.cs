using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : MonoBehaviour
{

    public GameObject startGame;
    public GameObject faces;
    public GameObject colours;

    void Start()
    {
        faces.SetActive(false);
        colours.SetActive(false);
    }

    public void ShowColours()
    {
        colours.SetActive(true);
        faces.SetActive(false);
        startGame.SetActive(false);
    }

    public void ShowFaces()
    {
        colours.SetActive(false);
        faces.SetActive(true);
        startGame.SetActive(false);
    }
   
}
