using UnityEngine;
using System.Collections;

public class FreeWheel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		audio.pitch = 1f + (FPSInputController.instance.motor.movement.velocity.magnitude / 10);
		if ((Input.GetAxis ("Vertical") > 0) && (!audio.isPlaying)){
			audio.Play ();
		}
	}
}
