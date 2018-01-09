using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_power : MonoBehaviour {

public int power = 4;

public GameObject batterySpawn;
public GameObject flashlight;

GameObject Player;

int checkBat;
	
	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag("player");
		batterySpawn = GameObject.FindWithTag("BatterySpawn");
		flashlight = Player;
		
	
	}
	
	// Update is called once per frame
	void Update () {
		checkBat = flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower;
		print("CkBat = "+checkBat);
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "player" && flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower == 0 ){
			flashlight.gameObject.GetComponentInChildren<FlashLight>().currentPower = power;
			Destroy(gameObject);
			batterySpawn.gameObject.GetComponentInChildren<BatterySpawner>().BatteryPickup();
		}
	}
}
