using UnityEngine;

public class Exercicio03repeticao : MonoBehaviour
{
    /*(C�lculo de moedas coletadas) O jogador coleta 3 moedas a
    cada fase. Ap�s 10 fases, exiba o total de moedas coletadas.*/

    [SerializeField] int moeda = 0;
   
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            moeda += 3;

            print(moeda);
        }
        print("Total de moedas: " +  moeda);
        
    }

    void Update()
    {
        
    }
}
