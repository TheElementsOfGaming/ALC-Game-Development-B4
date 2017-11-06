using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class FlashLight : MonoBehaviour {

public bool lightOn; 

Light light; 

//use this for initialization 
void Start() {
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
}