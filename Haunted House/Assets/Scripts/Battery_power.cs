using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery_power : MonoBehaviour {

public int power = 4;

public GameObject flashlight;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player"){

		}
	}
}
