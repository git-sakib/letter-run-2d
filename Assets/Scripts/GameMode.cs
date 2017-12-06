using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour {

	//public static GameMode instance;

	private int GameTick = 0;
	public int GameLevel = 0;

	// Use this for initialization
	void Start () {
		//if (instance == null) {
			//instance = this;
		//}
	}
	
	// Update is called once per frame
	void Update () {
		ManageTicks ();
		//Debug.Log (GameLevel);
	}

	void ManageTicks(){
		GameTick++;
		if (GameTick >= 500) {
			GameTick = 0;
			GameLevel++;
		}
	}
}
