using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMove : MonoBehaviour
{
    public int sceneBuildIndex;
    
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            LevelManager.Instance.LoadScene(sceneBuildIndex, "Fade");
        }
    }
}
