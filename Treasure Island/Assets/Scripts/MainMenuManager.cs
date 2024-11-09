using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;

    void ActivateOrDeactivate()
    {
        mainMenu.SetActive(!mainMenu.activeSelf);
        if (mainMenu.activeSelf)
        {
            Time.timeScale = 0;
        }
        if (!mainMenu.activeSelf)
        {
            Time.timeScale = 1;
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivateOrDeactivate();
        }
    }
}
