using UnityEngine;

/*
 (Verificar item de inventário) Um jogador possui itens limitados
no inventário. Verifique se o jogador possui uma "Poção de Vida".
Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
indisponível".*/

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoVida = true;
    void Start()
    {
        if (pocaoVida == true)
        {
            print("Usando Poção de vida");
        }
        else
        {
            print("Poção Indisponível");
        }
    }

    void Update()
    {
        
    }
}
