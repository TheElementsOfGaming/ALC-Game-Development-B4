using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class FlashLight : MonoBehaviour {

public bool lightOn; 
// Flashlight power capacity
public int maxPower = 4;
//Usable flashlight power
public int currentPower;
Light light; 

//use this for initialization 
void Start() {
	//Add power to flashlight
	currentPower = maxPower; 
	print("Power = " + currentPower);
	light = GetComponent<Light> ();
	lightOn = true;
	light.enabled= true; 
}

//update is called once per frame 
void Update (){
	//Toggle light on/off when L key is pressed.
	if (Input.GetKeyUp (KeyCode.F) && lightOn){
		lightOn = false;
		light.enabled = false;
	}
	else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
		lightOn = true; 
		light.enabled = true;
	
		}
	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;
	}
}
