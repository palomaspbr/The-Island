using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject tela1;
    public GameObject tela2;
    public GameObject preto;

    public SceneTransition transition;

    void Start()
    {
        tela1.SetActive(false);
        tela2.SetActive(false);
        preto.SetActive(true);
        StartCoroutine(Wait(tela1));
    }

    private IEnumerator Wait(GameObject tela){
        yield return transition.AnimateTransitionIn();
        tela.SetActive(true);
        yield return transition.AnimateTransitionOut();
        yield return new WaitForSeconds(5);
        yield return transition.AnimateTransitionIn();
        tela.SetActive(false);
        yield return transition.AnimateTransitionOut();
        StartCoroutine(Wait2(tela2));
    }
    
    private IEnumerator Wait2(GameObject tela){
        yield return transition.AnimateTransitionIn();
        tela.SetActive(true);
        yield return transition.AnimateTransitionOut();
        yield return new WaitForSeconds(5);
        yield return transition.AnimateTransitionIn();
        tela.SetActive(false);
        //yield return transition.AnimateTransitionOut();
        preto.SetActive(false);
        LevelManager.Instance.LoadScene(1, "Fade");
    }

}
