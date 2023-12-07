using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{

    [SerializeField] private int index;

    public GameObject startGame;
    public GameObject faces;
    public GameObject colours;

    public GameObject PlayerImage;
    public GameObject face;
    private Image faceImage;
    private Image colourImage;
    public GameObject colour;

    //public Sprite[] Images;
    public Texture2D[] Textures;

    void Start()
    {
        faces.SetActive(false);
        colours.SetActive(false);
        //PlayerImage.SetActive(false);

        colourImage = colour.GetComponent<Image>();
        faceImage = face.GetComponent<Image>();

    }

    public void ShowColours()
    {
        colours.SetActive(true);
        faces.SetActive(false);
        startGame.SetActive(false);
        //PlayerImage.SetActive(true);
    }

    public void ShowFaces()
    {
        colours.SetActive(false);
        faces.SetActive(true);
        startGame.SetActive(false);
        //PlayerImage.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void UpdatePreview(int index)
    {
        //faceImage.sprite = Images[index - 1];
        Texture2D texture = Textures[index - 1];
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);
        if (index > 6)
        {
            colourImage.sprite = sprite;
        } else
        {
            faceImage.sprite = sprite;
        }
    }


}
