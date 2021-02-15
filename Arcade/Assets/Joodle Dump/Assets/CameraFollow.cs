using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = .3f;
    private Vector3 currentVelocity;
    
    private void LateUpdate()
    {
        
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            //transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed * Time.deltaTime);
            transform.position = newPos;
      
    }
}
