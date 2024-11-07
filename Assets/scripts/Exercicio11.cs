using UnityEngine;

/*
 (Diálogos) Implemente um sistema de diálogos onde o jogador
pode interagir com um NPC (personagem não jogável), e o NPC
responde com diferentes frases dependendo do estado do jogo.
Use switch case para definir as respostas baseadas no estado do
jogador.*/

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int estado;
    void Start()
    {
        switch(estado)
        {
            case 1:
                print("Não Posso te ajudar");
                break;

            case 2:
                print("Vá para aquele lado");
                break;

            case 3:
                print("Cuidado");
                break;

            case 4:
                print("Bem-vindo a vila");
                break;

            default:
                print("Não tenho nada a dizer sobre isso!");
                break;
        }
    }

    void Update()
    {
        
    }
}
