using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointGenerator : MonoBehaviour {


	public GameObject spawnPointPrefab;
	private int startPos = -160;
	private int goalPos = 120; 

	// Use this for initialization
	void Start () 
	{
		for (float i = this.startPos; i < this.goalPos; i+=15)
		{
			GameObject spawnPoint = Instantiate (spawnPointPrefab) as GameObject;
			spawnPoint.transform.position = new Vector3 (0, 2.5f, i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
