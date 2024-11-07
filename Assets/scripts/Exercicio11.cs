using UnityEngine;

/*
 (Di�logos) Implemente um sistema de di�logos onde o jogador
pode interagir com um NPC (personagem n�o jog�vel), e o NPC
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
                print("N�o Posso te ajudar");
                break;

            case 2:
                print("V� para aquele lado");
                break;

            case 3:
                print("Cuidado");
                break;

            case 4:
                print("Bem-vindo a vila");
                break;

            default:
                print("N�o tenho nada a dizer sobre isso!");
                break;
        }
    }

    void Update()
    {
        
    }
}
