using System;
using UnityEngine;

public class Exercicio08repeticao : MonoBehaviour
{
    /*(Reverter uma string) Escreva um programa que inverte uma
    string usando um loop for.*/
    void Start()
    {
        string original = "Olá, Mundo!";

        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];  
        }

        print("String original: " + original);
        print("String invertida: " + invertida);
    }

    void Update()
    {
        
    }
}
