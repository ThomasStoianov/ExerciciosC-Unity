using UnityEngine;

/*
 (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
incompleta".*/

public class Exercicio05 : MonoBehaviour

{
    [SerializeField] float pontosGanhos = 0;
    void Start()
    {
        if (pontosGanhos >= 50)
        {
            print("Miss�o Bem-Sucedida");
        }
        else
        {
            print("Miss�o Incompleta");
        }
    }

  
    void Update()
    {
        
    }
}
