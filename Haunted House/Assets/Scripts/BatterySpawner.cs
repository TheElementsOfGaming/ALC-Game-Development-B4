using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour {

	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;
	// Use this for initialization
	void Start () {
		batSpawned = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(batSpawned == false){
			StartCoroutine(spawnBat(spawnTime, battery));
		}
		else{
			print("Battery hasn't spawned");
		}
	}
	void onTriggerEnter(Collision other){
		if(other.rigidbody.tag == "Battery"){
			batSpawned = true;
			}
	else{
		batSpawned = false;
			}
	}
	IEnumerator spawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		Instantiate(bat, spawnPoint.position, spawnPoint.rotation);
		batSpawned = true;

	}
}
