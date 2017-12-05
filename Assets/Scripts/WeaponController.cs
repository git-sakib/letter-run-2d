using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

	public GameObject stone;
	public LayerMask hitLayers;
	public Transform firePoint;

	// Use this for initialization
	void Awake () {
		firePoint = transform.Find ("FirePoint");
		if (firePoint == null) {
			Debug.LogError ("No Fire Point");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			Shoot ();
		}
	}

	void Shoot(){
		//RaycastHit2D hit = Physics2D.Raycast (firePoint.position, firePoint.position.);
		Instantiate(stone, firePoint.position, firePoint.rotation);
	}
}
