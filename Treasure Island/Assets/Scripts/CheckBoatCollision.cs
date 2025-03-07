using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoatCollision : MonoBehaviour
{
    private bool canWin;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(PlayerPrefs.GetInt("canWin") == 1)
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
            StartCoroutine(WaitAndTransition());
        }
    }

    IEnumerator WaitAndTransition()
    {
        yield return new WaitForSeconds(1.5f);
        LevelManager.Instance.LoadScene(8, "Fade");
    }
}
