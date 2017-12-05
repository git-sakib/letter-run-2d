using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 2f;
	public float jumpSpeed;

	public bool grounded;
	public LayerMask groundLayer;

	private Rigidbody2D playerRigidBody2D;
	private Animator playerAnimator;
	private Collider2D playerCollider;
	private float speed;
	private GameObject torch;

	private bool isTorchOn = false;
	private bool facingRight = true;

	// Use this for initialization
	void Start () {
		playerRigidBody2D = GetComponent<Rigidbody2D> ();
		playerAnimator = GetComponent<Animator> ();
		playerCollider = GetComponent<Collider2D> ();
		torch = GameObject.Find ("Torch");
		torch.SetActive (false);
		speed = moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
		// ------------------------------------------------------------------------------
		// FOR RUN AND IDLE 
		// ------------------------------------------------------------------------------

		// Get Input
/*		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			speed = moveSpeed;
			playerRigidBody2D.velocity = new Vector2(speed,playerRigidBody2D.velocity.y);
			playerAnimator.SetInteger ("MoveStatus",2);
		}
		else if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			speed = -moveSpeed;
			playerRigidBody2D.velocity = new Vector2(speed,playerRigidBody2D.velocity.y);
			playerAnimator.SetInteger ("MoveStatus",2);
		}
		else 
		{
			speed = 0f;
			playerAnimator.SetInteger ("MoveStatus",0);
		}

		// Change Direction
		if (Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow)) {
			if(!facingRight)ChangePlayerDirection ();
		}
		if (Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow)) {
			if(facingRight)ChangePlayerDirection ();
		}

		// ------------------------------------------------------------------------------
		// FOR JUMP
		// ------------------------------------------------------------------------------

		if (Input.GetKeyDown (KeyCode.Space)) {
			playerRigidBody2D.velocity = new Vector2(playerRigidBody2D.velocity.x, jumpSpeed);
		}
*/


		PlayerAnim ();
		PlayerJump ();

		TorchOnOff ();

	}

	void TorchOnOff(){
		if (Input.GetKeyDown (KeyCode.T)) {
			torch.SetActive (isTorchOn);
			isTorchOn = !isTorchOn;
			Debug.Log (isTorchOn);
		}
	}


	void PlayerAnim(){
		if (grounded) {
			playerAnimator.Play ("Run");
			playerAnimator.SetInteger ("MoveStatus",2);
		} else {
			playerAnimator.Play ("Idle");
			playerAnimator.SetInteger ("MoveStatus",0);
		}
	}

	void PlayerJump(){
		
		grounded = Physics2D.IsTouchingLayers (playerCollider, groundLayer);
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (grounded) {
				playerRigidBody2D.velocity = new Vector2 (0, jumpSpeed);
			}
		}
	}

	void ChangePlayerDirection(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
