﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

	public float ScrollSpeed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * ScrollSpeed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}

	void StopAll(){
		ScrollSpeed = 0;
	}
}
