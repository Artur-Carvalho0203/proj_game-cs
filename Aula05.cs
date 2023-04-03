using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula05 : MonoBehaviour
{
    int n1 = 10, n2 = 20, reSub, reMult, reDiv, reAdd;
    void Start()
    {
        reAdd = Add(n1, n2);
        reDiv = Div(n1, n2);
        reSub = Sub(n1, n2);
        reMult = Mult(n1, n2);
        print(reSub);
        print(reMult);
        print(reAdd);
        print(reDiv);
    }


    void Update()
    {

    }
    int Sub(int x, int y)
    {
        int res = y - x;
        return res;
    }
    int Mult(int x, int y)
    {
        int res = y * x;
        return res;
    }
    int Div(int x, int y)
    {
        int res = y / x;
        return res;
    }
    int Add(int x, int y)
    {
        int res = y + x;
        return res;
    }
}