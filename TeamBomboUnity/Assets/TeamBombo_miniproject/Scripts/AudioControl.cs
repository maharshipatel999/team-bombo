using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {
	public float HeadAlarmAngle = 30f;
	public AudioClip Startup, HeadTurn;

	// Use this for initialization
	void Start () {
		audio.clip = Startup;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.localEulerAngles.y > HeadAlarmAngle) && (transform.localEulerAngles.y < (360f - HeadAlarmAngle))
		    && (FPSInputController.instance.motor.movement.velocity.magnitude > 5)) {
			audio.clip = HeadTurn;
			if (!audio.isPlaying) audio.Play();	
			Debug.Log("Look Ahead Dumbass!");
		}
	}
}
