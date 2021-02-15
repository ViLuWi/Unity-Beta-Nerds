using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarCounter : MonoBehaviour
{
    public GameObject scoreText;
    public static int arcade_stars;

    void Start()
    {
        arcade_stars += 1;
        scoreText.GetComponent<Text>().text = "Sterne:" + arcade_stars;
    }
}
