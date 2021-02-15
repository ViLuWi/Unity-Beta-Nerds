using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform hero;
    public Text scoreText;
    private float lastScore = 0f;
    public float topScore = 10000;

    // Update is called once per frame
    void Update()
    {
        if (lastScore > 0 && (hero.position.y * 100) < lastScore)
        {
            scoreText.text = lastScore.ToString();
        }
        else
        {
            scoreText.text = Math.Floor(hero.position.y * 100).ToString();
            lastScore = hero.position.y * 100;
        }

        if (lastScore >= topScore)
        {   
            StarCounter.arcade_stars += 1;
            SceneManager.LoadScene("Arcade");
        }
    }
}
