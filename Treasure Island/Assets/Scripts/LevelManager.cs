using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    public GameObject transitionsContainer;

    private SceneTransition[] transitions;

    public bool HasMusic = false;

    public GameObject musica;
    private AudioSource audio;
    private bool isTransistioning;

    private void Awake(){
        /*if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }*/

        Instance = this;

        if (HasMusic)
        {
            audio = musica.GetComponent<AudioSource>();
        }
    }

    private void Start(){
        transitions = transitionsContainer.GetComponentsInChildren<SceneTransition>();
    }

    public void LoadScene(int sceneIndex, string transitionName){
        StartCoroutine(LoadSceneAsync(sceneIndex, transitionName));
    }

    private IEnumerator LoadSceneAsync(int sceneIndex, string transitionName){
        SceneTransition transition = transitions.First(t => t.name == transitionName);
        AsyncOperation scene = SceneManager.LoadSceneAsync(sceneIndex);
        scene.allowSceneActivation = false;

        if (HasMusic)
        {
            isTransistioning = true;
        }

        yield return transition.AnimateTransitionIn();

        scene.allowSceneActivation = true;
        yield return transition.AnimateTransitionOut();
    }

    private void Update()
    {
        if (isTransistioning)
        {
            audio.volume -= 0.01f;
            if(audio.volume == 0.005f)
            {
                Debug.Log("Chegou aqui!");
                isTransistioning = false;

            }
        }
    }

}
