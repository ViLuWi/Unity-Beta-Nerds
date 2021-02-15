﻿using UnityEngine;

public class PeriodicRotation : MonoBehaviour {
    public Vector3 speed;

	void Update () {
        this.transform.Rotate(speed * Time.deltaTime);
	}
}
