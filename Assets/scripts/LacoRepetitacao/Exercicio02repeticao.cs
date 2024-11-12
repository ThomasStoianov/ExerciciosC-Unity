using UnityEngine;

public class Exercicio02repeticao : MonoBehaviour
{
    /*(Multiplicação de dano) Um personagem ataca cinco vezes, e o
    dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
    ataque.*/

    int dano = 0;
    
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            dano += 2;
            print("Ataque " + i + " Dano " + dano);
        }
        
    }

    void Update()
    {
        
    }
}
