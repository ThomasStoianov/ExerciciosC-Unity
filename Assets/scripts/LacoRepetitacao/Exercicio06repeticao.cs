using UnityEngine;

public class Exercicio06repeticao : MonoBehaviour
{
    /*(Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
    �fizz� no console quando for divis�vel por 3, �buzz� quando for
    divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois. Se o
    n�mero n�o for divis�vel por nenhum deles, escreva-o no console.*/

    [SerializeField] int num = 1;
    void Start()
    {
        for (num = 1; num < 1000; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                print(num + "fizz buzz");
            }
            else if (num % 3 == 0)
            {
                print(num + "buzz");
            }
            else if (num % 5 == 0)
            {
                print(num + "fizz");
            }
            else
            {
                print(num + "esse n�mero n�o � divis�vel nem por 3 nem por 5");
            }
        }
    }

    void Update()
    {
        
    }
}
