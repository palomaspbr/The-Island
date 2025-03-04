using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapCodeGame : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;

    private int current;

    void Start()
    {
        current = 0;
    }

    public void Wall1()
    {
        if (current == 0 || current == 1 || current == 10 || current == 11 || current == 12 || current == 13 || current == 18 || current == 19 || current == 20 || current == 21 || current == 4 || current == 5 || current == 16)
        {
            audio.PlayOneShot(clip);
            current += 1;
        }
    }

    public void Wall2()
    {
        if (current == 2 || current == 3 || current == 14 || current == 15 || current == 22 || current == 23 || current == 6 || current == 7 || current == 8 || current == 9 || current == 17)
        {
            audio.PlayOneShot(clip);
            current += 1;
        }

    }


}
