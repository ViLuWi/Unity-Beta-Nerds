using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePlayer : MonoBehaviour
{
    private CharacterController _controller;
    public float _doubleJumpMultiply = 1;
    public float _jumpHeight = 1.5f;
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _gravity = 5f;
    private float _directionY;
    private bool _canDoubleJump = false;

    IEnumerator Start()
    {
        yield return null;
        _controller = GetComponent<CharacterController>();
        var checkForMazeGame = PlayerPrefs.GetFloat("MazeRunnerFinished", 0);
        if( checkForMazeGame == 1)
        {
            PlayerPrefs.DeleteAll();
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(61.84f, 10.29f, -20.476f);
            print("HHH");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        var rotatedDirection = transform.rotation * direction;

        if (_controller.isGrounded)
        {
            _canDoubleJump = true;
            if (Input.GetButtonDown("Jump"))
            {
                _directionY = _jumpHeight;
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump") && _canDoubleJump)
            {
                _directionY = _jumpHeight * _doubleJumpMultiply;
                _canDoubleJump = false;
            }
        }
        // set gravity
        _directionY -= _gravity * Time.deltaTime;
        rotatedDirection.y = _directionY;

        _controller.Move(rotatedDirection * _moveSpeed * Time.deltaTime);
    }
}
