using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MazeRunnerScript : MonoBehaviour
{
    public float speed = 3f;
    public int score = 0;
    public Text keyAmount;
    public Text win;
    [SerializeField]
    public float MazeRunnerFinished = 0;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move player
        if ((Input.GetKey(KeyCode.LeftArrow)) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if ((Input.GetKey(KeyCode.RightArrow)) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if ((Input.GetKey(KeyCode.UpArrow)) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if ((Input.GetKey(KeyCode.DownArrow)) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            if ((Input.GetKey(KeyCode.LeftArrow)) || Input.GetKey(KeyCode.A))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
            if ((Input.GetKey(KeyCode.RightArrow)) || Input.GetKey(KeyCode.D))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }
            if ((Input.GetKey(KeyCode.UpArrow)) || Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
            if ((Input.GetKey(KeyCode.DownArrow)) || Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
        }
        // Collect keys
        if (collision.gameObject.tag == "Keys")
        {
            Destroy(collision.gameObject);
            score++;
            keyAmount.text = "Keys: " + score;
        }

        // Hit enemy
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // load scene of activte scene
        }

        // door
        if (collision.gameObject.tag == "Door" && score == 3)
        {
            Destroy(collision.gameObject);
        }
        // Final Key
        if (collision.gameObject.tag == "FinalKey")
        {
            win.text = "You Win!";
            if (Time.time >= 5)
            {
                print("JEtzt");
            }
            MazeRunnerFinished = 1;
            PlayerPrefs.SetFloat("MazeRunnerFinished", 1);
            SceneManager.LoadScene("Arcade");
            StarCounter.arcade_stars += 1;
        }
    }
}
