using System.Collections.Generic;
using System;
using UnityEngine;

public class Exercicio07repeticao : MonoBehaviour
{
    /*(Maior n�mero em uma lista) Dada uma lista de n�meros,
    encontre o maior valor.*/
    void Start()
    {
       
        List<int> numeros = new List<int> { 10, 25, 3, 45, 7 };

        int maiorNumero = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        print("O maior n�mero �: " + maiorNumero); ;
    }

    void Update()
    {
        
    }
}
