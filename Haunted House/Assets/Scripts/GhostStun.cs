using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	//bool lightCheck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		
		if(other.gameObject.name == "Ghost"){
			print("Ghost is stunned and crying now!");	
			print("Why are you so mean?");	
		}
	}
}
