﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject target;
	public float distance;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (target.transform.position.x, target.transform.position.y+distance, transform.position.z);
	
	}
}
