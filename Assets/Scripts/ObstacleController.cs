using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

	public float obstacleSpeed = -1f;
	private Rigidbody2D obstacleBody;
	private GameObject destructionPoint;
	private GameMode gameMode;

	// Use this for initialization
	void Start () {
		destructionPoint = GameObject.Find ("DestructionPoint");
		obstacleBody = GetComponent<Rigidbody2D> ();
		obstacleSpeed = gameMode.GlobalScrollSpeed;
		//obstacleBody.velocity = new Vector2 (obstacleSpeed, obstacleBody.velocity.y);
	}

	// Update is called once per frame
	void Update () {
		obstacleBody.velocity = new Vector2 (obstacleSpeed, obstacleBody.velocity.y);
		if (transform.position.x < destructionPoint.transform.position.x) {
			gameObject.SetActive (false);
		}
	}
}
