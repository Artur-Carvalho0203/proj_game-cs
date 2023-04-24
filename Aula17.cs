using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula17 : MonoBehaviour
{

    void Start()
    {
        Dictionary<string, bool> personagem = new Dictionary<string, bool>();
        
                personagem.Add("Matador", true);
                personagem.Add("Coringa", false);

        Dictionary<string, double> moeda = new Dictionary<string, double>();

                moeda.Add("Matador", 12.0);
                moeda.Add("Coringa", 10.0);
      


        Dictionary<string, int> vida = new Dictionary<string, int>();

                vida.Add("Matador", 120);
                vida.Add("Coringa", 80);


        foreach(string chave in personagem.Keys)
        {
            print(
                "Power: " + personagem[chave] +
                " - Health: " + vida[chave] +
                " - Coins:  " + moeda[chave]
                );

        }

        }
    }


