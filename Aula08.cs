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
        print("10 é igual a 20?"+res);
        res = n1 != n2;
        print("10 é diferente de 20?"+res);
        res = n1 > n2;
        print("10 é maior que 20?"+res);
        res = n1 < n2;
        print("10 é menor que 20?"+res);
        res = n1 >= n2;
        print("10 é maior ou igual a 20?"+res);
        res = n1 <= n2;
        print("10 é menor ou igual a 20?"+res);
    }


    void Update()
    {
        
    }
}
