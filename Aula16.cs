using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula16 : MonoBehaviour
{

    void Start()
    {
        List<string> lista = new List<string>();
        
      
        lista.Add("Artur");
        lista.Add("Danilo");
        lista.Add("Gustavo");
        lista.Add("Kleber");


        foreach (string v in lista)
        { 
            print(v);
        }
    }

   
    void Update()
    {
        
    }
}
