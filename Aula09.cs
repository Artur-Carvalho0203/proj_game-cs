using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula09 : MonoBehaviour
{
    int n1=10, n2=20;

    void Start()
    {
        print(n1 == n2 && n1 == n2);
        print(n1 != n2! & n1 == n2);
        print(n1 != n2 & n1 == n2);
        print(n1 != n2 ^ n1 == n2);
        print(n1 > n2||n1 < n2);
        print(n1 >= n2! ^ n1 <= n2);
    }

    
    void Update()
    {
        
    }
}
