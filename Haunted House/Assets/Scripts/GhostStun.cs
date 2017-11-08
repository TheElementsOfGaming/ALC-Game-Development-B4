using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

		bool lightCheck;
		FlashLight flash;
		public GameObject ghost;

	// Use this for initialization
	void Start () {
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>();
		print("Obj:"+flash);
		flash.setLightOn();
		print("Start" + flash.isLightOn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print ("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true ){
			print("Ghost is stunned and crying now!");	
			print("Why are you so mean?");	



			other.GetComponent<GhostMove>().moveSpeed = 0f;
			StartCoroutine(Wait(5));
		}
	}

IEnumerator Wait(float time){
	yield return new WaitForSeconds(time);
	ghost.GetComponent<GhostMove>().moveSpeed = 8f;
		print ("Ghost is unstunned and he isn't happy now!");
	}
	
}
