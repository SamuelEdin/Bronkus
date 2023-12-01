using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    //creates a transform
    public Transform Player;
    
    //late update goes after update and fixed update so minimap camera follows after player moves
    void LateUpdate () 
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -20); //sets the position of the minimap camera
    }
}
