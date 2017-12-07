using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {


	public float platformSpeed = -0.3f;
	private Rigidbody2D platformBody;
	private GameObject destructionPoint;

	// Use this for initialization
	void Start () {
		destructionPoint = GameObject.Find ("DestructionPoint");
		//platformSpeed = Global.GlobalScrollSpeed;
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
