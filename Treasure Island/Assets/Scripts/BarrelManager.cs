using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelManager : MonoBehaviour
{
    private int contagem;
    private int num_prev = 0;
    public GameObject fim;

    void Start()
    {
        contagem = 0;
    }

    public void Click(int numero)
    {
        if(numero == 1)
        {
            contagem = 1;
            num_prev = numero;
        }
        else if (numero != 1 && numero == num_prev+1)
        {
            contagem += 1;
            num_prev = numero;

            if(contagem == 5)
            {
                Fim();
            }
        }
        else
        {
            contagem = 0;
            num_prev = 0;
        }


    }

    void Fim()
    {
        fim.SetActive(true);
    }

}
