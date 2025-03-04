using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTapCode : MonoBehaviour
{
    public int wall;
    public TapCodeGame tap;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Colidiu");

            if (wall == 1)
                tap.Wall1();

            if (wall == 2)
                tap.Wall2();
        }
    }
}
