using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftleg : MonoBehaviour
{
    private Animation run_anim;
    public Animation rightleg;
    public Animation rightarm;
    public Animation leftarm;
    private CharacterController _controller;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        // Define Animations
        run_anim = gameObject.GetComponent<Animation>();
        run_anim["leftleg"].layer = 123;
        rightleg = gameObject.GetComponent<Animation>();
        rightleg["rightleg"].layer = 123;
        rightarm = gameObject.GetComponent<Animation>();
        rightarm["rightarm"].layer = 123;
        leftarm = gameObject.GetComponent<Animation>();
        leftarm["leftarm"].layer = 123;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            run_anim.Play("leftleg");
            run_anim.Play("rightleg");
            run_anim.Play("rightarm");
            run_anim.Play("leftarm");
        }

    }
}
