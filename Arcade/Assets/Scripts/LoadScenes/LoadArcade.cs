using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadArcade : MonoBehaviour
{
    private int nextSceneToLoad;
    void Start()
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("Back to arcade");
            SceneManager.LoadScene(0);
        }
    }
}
