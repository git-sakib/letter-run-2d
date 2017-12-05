using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjects : MonoBehaviour {

	private Rigidbody2D rb2d;
	private BoxCollider2D box2d;
	private float bgSize; 

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		box2d = GetComponent<BoxCollider2D> ();

		//rb2d.velocity = new Vector2 (GameMode.instance.GlobalScrollSpeed, 0);

		//bgSize = box2d.size.x;
		bgSize = 20.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (box2d.size);
		if (transform.position.x < -bgSize) {
			RepeatBG ();
		}
		float bgx = transform.position.x; 
		bgx -= 0.05f; //GameMode.instance.GlobalScrollSpeed;
		transform.position = new Vector2 (bgx, transform.position.y);
	}

	private void RepeatBG(){
		Vector2 bgOffset = new Vector2 (bgSize * 2f, 0);
		transform.position = (Vector2)transform.position + bgOffset;
	}
}
