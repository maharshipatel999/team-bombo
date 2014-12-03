using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {
	public float HeadAlarmAngle = 30f;
	public AudioClip Startup, HeadTurn, Bell;

	// Use this for initialization
	void Start () {
		audio.clip = Startup;
		audio.Play ();
		StartCoroutine ("HeadTurnSound");
	}
	
	// Update is called once per frame
	IEnumerator HeadTurnSound() {
		while (true) {
			if ((transform.localEulerAngles.y > HeadAlarmAngle) && (transform.localEulerAngles.y < (360f - HeadAlarmAngle))
				&& (FPSInputController.instance.motor.movement.velocity.magnitude > 5)) {
		
				Debug.Log ("Look Ahead!");
				audio.clip = HeadTurn;
				if (!audio.isPlaying) {
					Intersection.instance.audio.mute = true;
					audio.Play ();
					yield return new WaitForSeconds (audio.clip.length);
					Intersection.instance.audio.mute = false;
				}
			}

			if (Input.GetButton("Fire2")){
				audio.clip = Bell;
				audio.Play ();
			}
			yield return new WaitForSeconds(1);
		}
	}

	void Update(){

	}
}
