using UnityEngine;
using System.Collections;

public class AudioControl : MonoBehaviour {
	public float HeadAlarmAngle = 30f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.localEulerAngles.y > HeadAlarmAngle) && (transform.localEulerAngles.y < (360f - HeadAlarmAngle))) {
			if (!audio.isPlaying) audio.Play();	
		}
	}
}
