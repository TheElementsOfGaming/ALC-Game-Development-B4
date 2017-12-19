using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour {

	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;
	// Use this for initialization
//void Start () {
		batSpawned = false;
	// }
	
	// // Update is called once per frame
	// void Update () {
	// 	if(batSpawned == false){
	// 		//StartCoroutine(spawnBat(spawnTime, battery));
	// 		print("Spawn box is empty");
	// 	}
	// 	else if(batSpawned == true)
	// 	{
	// 	print("Battery hasn't spawned");
	// 	}
	// }
	void onTriggerStay(Collider other){
	print("Collision Detected");
	// 	if(other.gameObject.tag == "Battery"){
	// 		batSpawned = true;
	// 		print("Battery is in the trigger");
	// 		}
	// else{
	// 	batSpawned = false;
	// 		print("Spawn Box is Empty");
	// 		}
	
	}
// 	IEnumerator spawnBat(float time, Rigidbody bat){
// 		yield return new WaitForSeconds(time);
// 		Instantiate(bat, spawnPoint.position, spawnPoint.rotation);
// 		batSpawned = true;
// 	}
 }