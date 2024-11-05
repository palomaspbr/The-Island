using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotDog : MonoBehaviour
{
    public int rotacoes;
    public float tempo = 0;

    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo >= 4f)
        {
            rotacoes = 0;
        }

        if(rotacoes == 13)
        {
            //faz algo
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            Rodou();
        }
    }

    private void Rodou()
    {
        tempo = 0;
        rotacoes += 1;
    }
}
