using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private GameObject _buttonPressed;

    void Start()
    {
        _audioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            _audioSource.PlayOneShot(_audioClip);
            _buttonPressed.SetActive(true);
            StartCoroutine(FinishAudio());
        }
    }

    IEnumerator FinishAudio()
    {
        yield return new WaitForSeconds(7f);
        _buttonPressed.SetActive(false);
    }
}
