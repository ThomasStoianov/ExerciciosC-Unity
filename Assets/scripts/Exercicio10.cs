using UnityEngine;

/*
 10. (Itens do invent�rio) Crie um script onde o jogador pode coletar
diferentes tipos de itens (como moedas, po��es, ou power-ups)
que t�m efeitos diferentes dependendo do tipo coletado. Use um
switch case para determinar o efeito de cada tipo de item.
*/

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocaoVida = false;
    void Start()
    {
     switch (tipoItem)
        {
            case "Moeda":
                    moeda++;
                print("Moeda coletada" + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("Escudo ativo");
                break;

            case "Po��o":
                pocaoVida = true;
                print("Po��o de vida coletada");
                break;

            default:
                Debug.Log("Item desconhecido");
                break;

        }   
    }


    void Update()
    {
        
    }
}
