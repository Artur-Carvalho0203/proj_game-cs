using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula08 : MonoBehaviour
{
    // Operadores Relacionais
    /*
     *== igual
     *!= diferente
     *> maior que
     *< menor que
     *>= maior ou igual a
     *<= menor ou igual a
     */

    int n1 = 10, n2 = 20;

    void Start()
    {
        bool res;
        res = n1 == n2;
        print("10 � igual a 20?"+res);
        res = n1 != n2;
        print("10 � diferente de 20?"+res);
        res = n1 > n2;
        print("10 � maior que 20?"+res);
        res = n1 < n2;
        print("10 � menor que 20?"+res);
        res = n1 >= n2;
        print("10 � maior ou igual a 20?"+res);
        res = n1 <= n2;
        print("10 � menor ou igual a 20?"+res);
    }


    void Update()
    {
        
    }
}
