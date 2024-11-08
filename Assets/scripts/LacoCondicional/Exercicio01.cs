using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Exercicio01 : MonoBehaviour

//    1. (Verificação de pontos de vida) Um personagem perde pontos
//de vida após uma batalha.Verifique se ele ainda está vivo.Caso
//tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso
//contrário, "Game Over".

{
    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int morte = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (vidaHeroi > morte)
        {
            print("Personagem vivo");
        }
        else
        {
            print("GameOver");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
