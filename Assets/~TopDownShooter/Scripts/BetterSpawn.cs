using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterSpawn : MonoBehaviour {

	 
	public GameObject enemy;  //Get Object to spawn             
	public float spawnTime = 3f; //Spawn interval           
	public Transform[] spawnPoints; //Spawn point array


	void Start ()
	{
		//Start the loop of spawning
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		//Chooses a random spawn point in the array
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        //Spawns objects
		Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
