using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour {

	private Light sun;

	// Use this for initialization
	void Start () {
		sun = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(sun.intensity < 1.0f)sun.intensity += 0.001f;
	}
}
