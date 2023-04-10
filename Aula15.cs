using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula15 : MonoBehaviour
{
   int[] pos;
    
    void Start()
    {
        pos = new int[3];
        pos[0] = 23;
        pos[1] = 52;
        pos[2] = 54;

        foreach (int x in pos)
        {
            print(x);
        }

    }

    void Update()
    {
        
    }
}
