using UnityEngine;
using System.Collections;

public class Intersection : MonoBehaviour {
	public AudioClip[] RouteClip = new AudioClip[5];
	public GameObject RouteObject;
	RectTransform Route;
	AudioSource RouteSource;
	int RouteNumber;

	// Use this for initialization
	void Start () {
		Route = RouteObject.GetComponent("Transform") as RectTransform;
		RouteSource = RouteObject.GetComponent("AudioSource") as AudioSource;
		RouteNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.position.z < -55) && (transform.position.z > -85) && 
						(transform.position.x > 35) && (transform.position.x < 115) && (Input.GetButton ("Fire1"))) {
			RouteSource.clip = RouteClip[RouteNumber];
			RouteSource.Play ();
			if (RouteNumber == 4)	RouteNumber = 0;
			else RouteNumber += 1;
		}
	}

}
