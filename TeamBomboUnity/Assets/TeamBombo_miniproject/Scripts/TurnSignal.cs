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

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "First Person Controller") {
			audio.clip = TurnTrack;
			audio.Play ();
		}
	}
}
