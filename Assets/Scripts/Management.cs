using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Management : MonoBehaviour
{
    public List <string> pickedUpKeys = new List<string> { };

    public List <string> pickedSebbes = new List<string> { };

    [SerializeField] GameObject sebbeDoor;

    public int maxSebbes = 6;
    public int sebbes = 0;

    public void addKey(string key)
    {
        pickedUpKeys.Add(key);
        sebbes++;
    }

    public void addSebbe(string sebbe)
    {
        pickedSebbes.Add(sebbe);

    }

    private void Update()
    {
        if (pickedSebbes.Count == maxSebbes)
        {
            Destroy(sebbeDoor);
        }
    }
}
