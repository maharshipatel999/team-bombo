using UnityEngine;
using System.Collections;

public class AmbientPothole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (FPSInputController.instance.motor.movement.velocity.magnitude < 3f) {	
						audio.Pause ();
						Debug.Log ("Ambient Pothole Paused");
				} else if (!audio.isPlaying) {
						audio.Play ();
						Debug.Log ("Ambient Pothole resumed");
				}
	}
}
