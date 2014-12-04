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
			audio.volume = 1.0f;
			Intersection.instance.audio.mute = true;
			audio.pan = 0f;
			audio.Play ();
			yield return new WaitForSeconds(0.2f);
			audio.pan = -0.2f;
			yield return new WaitForSeconds(0.2f);
			audio.pan = -0.4f;
			yield return new WaitForSeconds(0.2f);
			audio.pan = -0.6f;
			yield return new WaitForSeconds(0.2f);
			audio.pan = -0.8f;
			yield return new WaitForSeconds(0.2f);
			audio.pan = -1f;
			yield return new WaitForSeconds(audio.clip.length - 1f);
			audio.pan = 0f;
			Intersection.instance.audio.mute = false;

		}
	}
}
