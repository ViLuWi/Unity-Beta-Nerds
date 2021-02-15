using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public AudioSource collectSound;


    void OnTriggerEnter2D(Collider2D collider) {
        collectSound.Play();
        LevelMenu.RBStars += 1;
        SceneManager.LoadScene(0);
    }
}
