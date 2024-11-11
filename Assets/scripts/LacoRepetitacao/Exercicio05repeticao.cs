using UnityEngine;

public class Exercicio05repeticao : MonoBehaviour
{
    /*(Aumento de nível de dificuldade) A cada fase completada, a
    dificuldade aumenta em 5 pontos. Exiba a dificuldade após cada
    fase, em um total de 6 fases.*/

    [SerializeField] int dificuldadeFase = 0;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            dificuldadeFase += 5;
        }

        print(dificuldadeFase);
    }

    
    void Update()
    {
        
    }
}
