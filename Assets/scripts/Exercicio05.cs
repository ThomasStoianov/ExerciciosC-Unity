using UnityEngine;

/*
 (Pontuação de missão) Após completar uma missão, o jogador
recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
exiba "Missão bem-sucedida"; caso contrário, "Missão
incompleta".*/

public class Exercicio05 : MonoBehaviour

{
    [SerializeField] float pontosGanhos = 0;
    void Start()
    {
        if (pontosGanhos >= 50)
        {
            print("Missão Bem-Sucedida");
        }
        else
        {
            print("Missão Incompleta");
        }
    }

  
    void Update()
    {
        
    }
}
