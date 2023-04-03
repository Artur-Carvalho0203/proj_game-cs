using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula10 : MonoBehaviour
{
    int moedaHeroi = 80;
    int valorVida = 100;

    void Start()
    {
       if(moedaHeroi == valorVida)
        {
            print("Posso comprar a vida, mas fico zerado.");
        }
        else if(moedaHeroi > valorVida)
        {
            print("Posso comprar a vida e sobra dinheiro.");
        }
            else
        {
            print("Não tenho dinheiro");
        }
    }



    
    
    void Update()
    {
        
    }
}
