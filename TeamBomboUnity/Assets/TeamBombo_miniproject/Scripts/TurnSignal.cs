using UnityEngine;
using System.Collections;

public class TurnSignal : MonoBehaviour {
	public AudioClip TurnTrack;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator OnTriggerEnter(Collider col){
		if (col.gameObject.name == "First Person Controller") {
			audio.clip = TurnTrack;
			Intersection.instance.audio.mute = true;
			audio.Play ();
			yield return new WaitForSeconds(audio.clip.length);
			Intersection.instance.audio.mute = false;

		}
	}
}
