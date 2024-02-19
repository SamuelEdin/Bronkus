using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Management : MonoBehaviour
{
    public List <string> pickedUpKeys = new List<string> { };

    public void addKey(string key)
    {
        pickedUpKeys.Add(key);
    }
}
