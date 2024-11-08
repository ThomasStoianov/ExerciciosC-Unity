using Unity.VisualScripting;
using UnityEngine;

public class Exercicio02 : MonoBehaviour

//    2. (Detecção de power-up) Ao coletar um power-up, o
//personagem aumenta sua velocidade.Se o jogador encontrar um
//power-up, exiba "Power-up Coletado". Caso contrário, exiba
//"Nenhum power-up encontrado".
{
    [SerializeField] bool powerup = true;
    void Start()
    {
        if (powerup == true)
        {
            print("Power-Up Coletado");
        }
        else
        {
            print("Nenhum Power-Up Coletado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
