using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBarrel : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip clip;
    public GameObject text;
    public GameObject levelMoveForward;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        audio.PlayOneShot(clip);
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        Collider2D col = this.transform.GetComponent<Collider2D>();
        col.enabled = false;
        yield return new WaitForSeconds(.7f);
        this.gameObject.SetActive(false);
        text.SetActive(false);
        levelMoveForward.SetActive(true);
    }
}
