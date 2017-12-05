using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	public float bulletForce = 10.0f;
	public float bullerForceUp = 3.0f;

	private bool isShooting = false;

	private Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
		bullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//bullet.velocity = new Vector2 (0, bullerForceUp);
		if (!isShooting) {
			bullet.velocity = new Vector2 (transform.localScale.x * bulletForce, bullerForceUp);
			isShooting = true;
		}
		if (gameObject.transform.position.y < -10.0f) {
			Destroy (gameObject);
			isShooting = false;
		}

		//Debug.Log (bullet.velocity);
	}

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log (gameObject.transform.position.y);
		if (other.gameObject.tag == "Ground" || gameObject.transform.position.y < -10.0f) {
			Destroy (gameObject);
			isShooting = false;
		}
		//Destroy (gameObject);	
	}


}
