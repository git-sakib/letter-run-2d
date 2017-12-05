﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {


	public float platformSpeed = -0.1f;
	private Rigidbody2D platformBody;
	private GameObject destructionPoint;
	private GameMode gameMode;

	// Use this for initialization
	void Start () {
		destructionPoint = GameObject.Find ("DestructionPoint");
		platformSpeed = gameMode.GlobalScrollSpeed;
		platformBody = GetComponent<Rigidbody2D> ();
		platformBody.velocity = new Vector2 (platformSpeed, platformBody.velocity.y);
	}
	
	// Update is called once per frame
	void Update () {
		platformBody.velocity = new Vector2 (platformSpeed, platformBody.velocity.y);
		if (transform.position.x < destructionPoint.transform.position.x) {
			gameObject.SetActive (false);
		}
	}
}
