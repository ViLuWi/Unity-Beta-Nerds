﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelMenu : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;
    public string MainGameScene;

    public static int RBStars;
    public GameObject starDisplay;

    public void Start()
    {
        starDisplay.GetComponent<TextMeshProUGUI>().text = "Diamonds: " + RBStars;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayLevelOne()
    {
        SceneManager.LoadScene("Level 01");
        PauseMenu.GameIsPaused = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Arcade");
    }
}
