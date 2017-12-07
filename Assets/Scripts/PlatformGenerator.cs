using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public GameObject platform;
	public Transform generationPoint;
	public Transform destructionPoint;
	public float distanceBetweenMax = 10f;
	public float distanceBetweenMin = 3f;
	public int maxPlatforms;

	public ObjectPooler objectPooler;

	private float platformWidth;
	private float distanceBetween;
	private Vector2 platformPosition;

	// Use this for initialization
	void Start () {
		//objectPooler = FindObjectOfType<ObjectPooler> ();
		Debug.Log (objectPooler.pooledAmount);
		GeneratePlatform ();
	}
	
	// Update is called once per frame
	void Update () {
		//GeneratePlatform (platform);
	}


	void GeneratePlatform(){


		platformPosition = new Vector2(generationPoint.position.x, generationPoint.position.y);
		platformWidth = platform.GetComponent<BoxCollider2D> ().size.x;

		for (int i = 0; i < maxPlatforms; i++) {
			
			distanceBetween = Random.Range (distanceBetweenMin, distanceBetweenMax);

			//Instantiate (platform, platformPosition, generationPoint.rotation);
			GameObject newPlatform = objectPooler.GetPooledObject();
			newPlatform.SetActive(true);
			newPlatform.transform.position = platformPosition;
			newPlatform.transform.rotation = generationPoint.rotation;
			Debug.Log (newPlatform.transform.position.x);

			platformPosition = new Vector2 (platformPosition.x + platformWidth + distanceBetween, platformPosition.y + 3);
			//Debug.Log (platformPosition);
		}
	}

}
