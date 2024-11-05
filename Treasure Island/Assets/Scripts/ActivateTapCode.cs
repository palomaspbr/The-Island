using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTapCode : MonoBehaviour
{
    public int wall;
    public TapCodeGame tap;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Colidiu");

            if (wall == 1)
                tap.Wall1();

            if (wall == 2)
                tap.Wall2();

            if (wall == 3)
                tap.Wall3();

            if (wall == 4)
                tap.Wall4();
        }
    }
}
