using UnityEngine;

/*(Dado com N faces) Para fazer um jogo de RPG, vamos precisar
calcular probabilidades e simular a rolagem de dados. Crie um
script em que o usu�rio defina o n�mero de faces de um dado
(int) e calcule a rolagem de um dado com esse n�mero de faces.
Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
valor_max); (Coloque o c�digo dentro da fun��o-evento Start).*/

public class Exercicio07 : MonoBehaviour
{
    [SerializeField] int facesDados = 6;

    void Start()
    {
       int resultado =  Random.Range(1,facesDados);
        print(resultado);
    }

    
    void Update()
    {
        
    }
}
