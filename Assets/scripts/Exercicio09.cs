using UnityEngine;

/*
 (Placar final) Crie um script que l� o placar de uma partida entre
time A e time B. Depois, escreva no console qual dos tr�s
resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
ou empate. Se o empate teve mais de 3 pontos para cada lado,
escreva que foi �um empate emocionante�.*/

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int timeA;
    [SerializeField] int timeB;
   
    void Start()
    {
        if (timeA > timeB)
        {
            print("Vit�ria do time A");
        }

        else if (timeA < timeB)
        {
            print("Vit�ria do time B");
        }

        else if (timeA >= 3 && timeB >= 3 && timeA == timeB)
        {
            print("Empate emocionante!");
        }

        else if (timeA == timeB)
        {
            print("Empate!");
        }


    }

    
    void Update()
    {
        
    }
}
