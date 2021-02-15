using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadRunBoy : MonoBehaviour
{
    private int nextSceneToLoad;
    void Start()
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("Run Boy");
            SceneManager.LoadScene("Run Boy");
        }
    }
}
