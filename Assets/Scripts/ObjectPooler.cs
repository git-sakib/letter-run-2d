using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

	public GameObject pooledObject;
	public int pooledAmount;

	public List<GameObject> pooledObjects;

	// Use this for initialization
	void Start () {
		pooledObjects = new List<GameObject> ();

		for (int i = 0; i < pooledAmount; i++) {
			GameObject obj = (GameObject)Instantiate (pooledObject);
			obj.SetActive(false);
			pooledObjects.Add (obj);
		}

		//Debug.Log (pooledObjects.Count);
	}

	// GET THE NEXT OBJECT FROM THE POOL
	public GameObject GetPooledObject(){

		Debug.Log (pooledObjects.Count);

		for (int i = 0; i < pooledObjects.Count; i++) {
			if (!pooledObjects [i].activeInHierarchy) {
				return pooledObjects [i];
			}
		}

		GameObject obj = (GameObject)Instantiate (pooledObject);
		obj.SetActive(false);
		pooledObjects.Add (obj);
		return obj;

		return null;
	}
		
}
