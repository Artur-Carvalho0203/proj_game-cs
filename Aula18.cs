using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula18 : MonoBehaviour
{
    enum Personagem { Atacar=0,Correr=1,Andar=0 }

    void Start()
    {
        Personagem Matador = Personagem.Atacar;
        Personagem Mago = Personagem.Correr;
        Personagem Gladiador = Personagem.Andar;

        int v1 = (int)Matador;
        int v2 = (int)Mago;
        int v3 = (int)Gladiador;

        print(v1);
        print(v2);
        print(v3);

    }
    void Update()
    {
        
    }
}
