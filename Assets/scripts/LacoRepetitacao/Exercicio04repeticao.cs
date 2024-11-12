using UnityEngine;

public class Exercicio04repeticao : MonoBehaviour

    /*(Pontuação em combos) Cada combo realizado aumenta em 10
    pontos. Exiba a pontuação total após 7 combos.*/
{
    [SerializeField] int pontuacao = 0;
    void Start()
    {
        for (int i = 1; i <= 7; i++)
        {
            pontuacao += 10;
        }


        print("Total da pontuação: " + pontuacao);
    }

    
    void Update()
    {
        
    }
}
