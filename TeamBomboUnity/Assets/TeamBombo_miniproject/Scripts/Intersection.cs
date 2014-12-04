using UnityEngine;
using System.Collections;

public class Intersection : MonoBehaviour {
	public static Intersection instance;
	public AudioClip[] RouteClip = new AudioClip[5];
	public AudioClip[] Music = new AudioClip[4];
	public GameObject RouteObject;
	RectTransform Route;
	AudioSource RouteSource;
	int RouteNumber;

	// Use this for initialization
	void Start () {
		instance = this;

		RouteSource = RouteObject.GetComponent("AudioSource") as AudioSource;
		RouteNumber = 0;

		StartCoroutine("RouteSonification");
	}
	
	// Update is called once per frame
	IEnumerator RouteSonification () {
		while (true) {
			if (Input.GetButton ("Fire1")) {

				RouteSource.volume = 0.5f;
				RouteSource.clip = RouteClip [RouteNumber];
				Debug.Log ("Route Sonification");
				RouteSource.Play ();
				audio.mute = true;
				yield return new WaitForSeconds (RouteSource.clip.length);
				audio.mute = false;
			
				if (RouteNumber == 4)
					RouteNumber = 0;
				else
					RouteNumber += 1;
				}
				
			if ((!audio.isPlaying)) {
				audio.clip = Music [Random.Range (0, 4)];
				audio.Play ();
				Debug.Log ("Playing Music");
			}


			yield return new WaitForSeconds(1);
			}
	}

	void Update(){}

}
