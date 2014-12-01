using UnityEngine;
using System.Collections;

public class Crime : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		if ((col.gameObject.name == "First Person Controller") && (FPSInputController.instance.motor.movement.velocity.magnitude < 15f)){
			audio.Play ();
			Debug.Log ("High Crime Area!");
		}
	}
}
