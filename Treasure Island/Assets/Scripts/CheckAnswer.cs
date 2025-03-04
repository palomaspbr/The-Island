using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;
using System.Text;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private string answer;
    public TMP_InputField input;
    public int CurrentScene;

    public void Answer()
    {
        string text = sha256(input.text);
        if (text == answer)
            LevelManager.Instance.LoadScene(CurrentScene + 1, "Fade");
    }

    static string sha256(string randomString)
    {
        var crypt = new System.Security.Cryptography.SHA256Managed();
        var hash = new System.Text.StringBuilder();
        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
        foreach (byte theByte in crypto)
        {
            hash.Append(theByte.ToString("x2"));
        }
        return hash.ToString();
    }
}
