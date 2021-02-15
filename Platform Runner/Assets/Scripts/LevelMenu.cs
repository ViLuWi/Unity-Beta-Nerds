using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;
    public string MainGameScene;

    public void PlayLevelOne ()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        SceneManager.LoadScene(MainGameScene);
    }
}
