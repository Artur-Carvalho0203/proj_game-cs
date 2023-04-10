using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula14 : MonoBehaviour
{
    int y = 0, x = 19;
    void Start()
    {
        do
        {
            x++;
            print(x);
        }
        while (x < y);
        print(x);
    }



    void Update()
    {
        
    }
}
