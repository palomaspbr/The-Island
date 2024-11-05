using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCameraFollow : MonoBehaviour
{
    public GameObject script;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            script.SetActive(true);
        }
    }
}
