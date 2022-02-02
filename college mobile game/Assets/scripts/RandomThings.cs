using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomThings : MonoBehaviour
{
    string[] Options=new string[] { "ladder", "snake", "push" };
    void Update()
    {
        print (random(Options));
    }

    string random(string[] Options)
    {
        return Options [Random.Range(0,Options.Length)];    
    }
}
