using UnityEngine;

/*
 (Verificar item de invent�rio) Um jogador possui itens limitados
no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
indispon�vel".*/

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoVida = true;
    void Start()
    {
        if (pocaoVida == true)
        {
            print("Usando Po��o de vida");
        }
        else
        {
            print("Po��o Indispon�vel");
        }
    }

    void Update()
    {
        
    }
}
