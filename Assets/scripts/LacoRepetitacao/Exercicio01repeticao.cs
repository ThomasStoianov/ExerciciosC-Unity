using UnityEngine;

public class Exercicio01repeticao : MonoBehaviour
{
    /*(Contagem regressiva de tempo) Crie uma contagem
    regressiva de 5 a 1 e exiba "Início da partida!" ao final.*/
    void Start()
    {
        for(int i = 5; i > 0; i--)
        {
            print(i);
        }

        print("Inicio da partida");

    }

    void Update()
    {
        
    }
}
