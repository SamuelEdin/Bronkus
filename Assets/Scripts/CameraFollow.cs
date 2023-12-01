using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;

    void Update()
    {
        transform.position = player.position + new Vector3(0,0,-10); //camera is set at the same position of player with different z value
        
    }
}
