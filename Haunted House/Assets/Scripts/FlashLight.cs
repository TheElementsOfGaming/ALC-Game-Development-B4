using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using UnityEngine.UI;

public class FlashLight : MonoBehaviour {

public bool lightOn; 
// Flashlight power capacity
public int maxPower = 4;
//Usable flashlight power
public int currentPower;

public int batDrainAmt;

public float batDrainDelay;
Light light; 
bool draining = false;
long count = 0;
// Get Battery UI Text
public Text batteryText;

//use this for initialization 
void Start() {
	//Add power to flashlight
	currentPower = maxPower; 
	print("Power = " + currentPower);
	
	light = GetComponent<Light> ();
	lightOn = true;
	print("Turn light on when FlashLight is initiated");
	light.enabled= true; 
}

//update is called once per frame 
void Update (){
	//Toggle light on/off when L key is pressed.
	if (Input.GetKeyUp (KeyCode.F) && lightOn){
		lightOn = false;
		light.enabled = false;
	}
	else if (Input.GetKeyUp (KeyCode.F) && !lightOn && currentPower > 0){
		lightOn = true; 
		light.enabled = true;
	
		}
		//Update Battery UI Text
		batteryText.text = currentPower.ToString();

		//Drain Battery Life
		if(currentPower > 0 && lightOn){
			if(!draining){
				StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
			}
			else if(currentPower <= 0){
				lightOn = false;
				light.enabled = false;
			}
		}
	}
	public void setLightOn(){
		lightOn = true;
	}
	public bool isLightOn(){
		return lightOn;
	}
	IEnumerator BatteryDrain(float delay, int amount){
		if(lightOn){
			draining = true;
			yield return new WaitForSeconds(delay);
			print(currentPower);
			currentPower -=amount;

		}
		if(currentPower <= 0){
			currentPower = 0;
			print("Battery is dead!");
			light.enabled = false;
		}
		draining = false;
	}
}
