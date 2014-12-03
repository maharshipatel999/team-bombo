using UnityEngine;
using System.Collections;

public class PotHole : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(Collider col){
		if (col.gameObject.name == "First Person Controller") {
			Intersection.instance.audio.mute = true;
			Debug.Log ("Pothole Ahead!");
			audio.Play ();
			yield return new WaitForSeconds(audio.clip.length);
			Intersection.instance.audio.mute = false;

		}
	}
}
