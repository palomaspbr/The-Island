using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotDog : MonoBehaviour
{
    public int rotacoes;
    public float tempo = 0;

    private AudioSource audio;
    public AudioClip clip;

    public GameObject texto;
    public GameObject texto_novo;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        tempo += Time.deltaTime;

        if(tempo >= 4f)
        {
            rotacoes = 0;
        }

        if(rotacoes == 13)
        {
            audio.PlayOneShot(clip);
            texto.SetActive(false);
            texto_novo.SetActive(true);
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
