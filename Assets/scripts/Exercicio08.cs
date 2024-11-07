using System.Threading.Tasks;
using UnityEngine;

/*
 (Contador de horas e dias) Crie um script que em que uma
variável inteira hora seja incrementada de uma unidade a cada 10
segundos e volte a ser 0 quando alcançar o valor 24. Quando
completar um ciclo, incremente uma variável dias e escreva o
número de dias que se passaram no console. (Coloque o código
dentro da função-evento Update).
*/

public class Exercicio08 : MonoBehaviour
{
    [SerializeField] int horas = 0;
    [SerializeField] int dias = 0;
    [SerializeField] float segundos = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        segundos += Time.deltaTime;

        if(segundos >= 10f)
        {
            horas++;
            segundos = 0;
            if(horas == 24)
            {
                dias++;
                horas = 0;
                print(dias);
            }
        }
    }
}
