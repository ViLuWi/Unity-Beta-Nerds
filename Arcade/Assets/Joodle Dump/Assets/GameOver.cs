using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class GameOver : MonoBehaviour
{
    public Transform target;
    public Rigidbody2D hero;
    private Vector3 velocity;

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(0);
    }

    private void FixedUpdate()
    {
        velocity = hero.velocity;
        if (hero.velocity.y > 0)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y -10f, -10f);
            transform.position = newPos;
        }
    }
}
