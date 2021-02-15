using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadCorsairs : MonoBehaviour
{
    private int nextSceneToLoad;
    AudioSource m_MyAudioSource;
    void Start()
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            m_MyAudioSource = GetComponent<AudioSource>();
            m_MyAudioSource.Play();
            SceneManager.LoadScene("Corsairs");
        }
    }
}
