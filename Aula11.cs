using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula11 : MonoBehaviour
{
    int moedaHeroi = 80;
    int valorVida = 100;

    void Start()
    {
        if (moedaHeroi < valorVida)
        {
            print("N�o consigo comprar.");
        }
        else
        {
            string res = (moedaHeroi == valorVida) ? "N�o tenho dinheiro" : "Posso comprar a vida e sobra dinheiro.";
            print(res);
        }
    }





    void Update()
    {

    }
}