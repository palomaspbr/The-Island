using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBarrels : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip clip;
    public int numero;
    public BarrelManager manager;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        audio.PlayOneShot(clip);
        manager.Click(numero);
    }
}
