using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public static LevelChanger Instance { get; private set; }
    Animator animator;

    AsyncOperation levelLoadingTask;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            animator = GetComponent<Animator>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadLevel(int levelIndex)
    {
        animator.SetTrigger("FadeOut");
        levelLoadingTask = SceneManager.LoadSceneAsync(levelIndex);
    }

    //IEnumerator loadLevel(int levelIndex)
    //{
    //    levelLoadingTask = SceneManager.LoadSceneAsync(levelIndex);
    //    //levelLoadingTask.allowSceneActivation = false;

    //    yield return null;

    //    while(!levelLoadingTask.isDone)
    //    {
    //        if(levelLoadingTask.progress >= 0.9)
    //        {
    //            animator.SetTrigger("FadeIn");
    //            //levelLoadingTask.allowSceneActivation = true;
    //        }
    //    }
    //}

    IEnumerator FadeIn()
    {
        while(!levelLoadingTask.isDone)
        {
            yield return null;
        }

        animator.SetTrigger("FadeIn");
    }
}
