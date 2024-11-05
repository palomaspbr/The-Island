using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoatCollision : MonoBehaviour
{
    private bool canWin;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        canWin = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        canWin = false;
    }

    private void Update()
    {
        if (canWin && Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Yay");
        }
    }
}
