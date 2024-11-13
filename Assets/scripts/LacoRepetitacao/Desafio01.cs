using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    /*Escreva um programa que conta o número de consoantes em uma string.*/

    [SerializeField] string texto = "Jogos Digitais";
    [SerializeField] int contadorConsoantes;
    void Start()
    {
        //for(inicializador; condição; incremento ou decremento)
        for (int i = 0; i < texto.Length; i++)
        {
            char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(letra) || "BCDFGHJKLMNPQRSTVWXYZ".Contains(letra))
            {
                contadorConsoantes++;
            }
        }
        print("O número de consoantes é " + contadorConsoantes);
    }

    void Update()
    {
        
    }
}
