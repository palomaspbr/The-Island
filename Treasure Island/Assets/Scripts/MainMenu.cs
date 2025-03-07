using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("1 - Beach");
        PlayerPrefs.SetInt("barrel", 0);
        PlayerPrefs.SetInt("canWin", 0);
        Time.timeScale = 1;
    }

}
