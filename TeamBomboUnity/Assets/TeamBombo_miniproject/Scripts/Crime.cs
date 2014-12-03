using UnityEngine;
using System.Collections;

public class Crime : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator OnTriggerEnter(Collider col){
		if ((col.gameObject.name == "First Person Controller") && (FPSInputController.instance.motor.movement.velocity.magnitude < 15f)){
			Debug.Log ("High Crime Area!");
			Intersection.instance.audio.mute = true;
			audio.Play ();
			yield return new WaitForSeconds(audio.clip.length);
			Intersection.instance.audio.mute = false;
	
		}
	}
}
