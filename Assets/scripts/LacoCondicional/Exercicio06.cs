using UnityEngine;

/*
 (Escolha de personagem) O jogador pode escolher entre o
personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
jogador selecionar Guerreiro e "Mago escolhido" se selecionar
Mago.*/

public class Exercicio06 : MonoBehaviour
{
    [SerializeField] bool mago = true;
    void Start()
    {
        if (mago == true)
        {
            print("Mago Escolhido");
        }
        else
        {
            print("Guerreiro Escolhido");
        }
    }


    void Update()
    {
        
    }
}
