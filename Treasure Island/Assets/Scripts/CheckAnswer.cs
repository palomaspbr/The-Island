using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
    public string answer;
    public TMP_InputField input;
    public int CurrentScene;

    public void Answer()
    {
        string text = input.text;
        if (text == answer)
            LevelManager.Instance.LoadScene(CurrentScene + 1, "Fade");
    }
}
