﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour {
    public int velRot;
	void Start () {
		
	}

	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * velRot);
	}
}
