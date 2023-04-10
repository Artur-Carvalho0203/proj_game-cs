using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula12 : MonoBehaviour
{
    int estados = 5;
    void Start()
    {
        switch (estados)
        {

            case 1:
                print("pouco");
                break;
            case 2:
                print("bom");
                break;
            case 3:
                print("demais");
                break;
            case 4:
                print("horrível");
                break;
            default:
                print("lixo");
                break;
        }
    }


    void Update()
    {
        
    }
}
