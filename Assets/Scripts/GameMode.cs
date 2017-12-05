using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour {

	public static GameMode instance;
	public float GlobalScrollSpeed = -1.5f;

	public int GameTick = 0;
	public int GameLevel = 0;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () {
		ManageTicks ();
		//Debug.Log (GameLevel);
	}

	void ManageTicks(){
		if (GameTick >= 500) {
			GameLevel++;
		}
	}
}
