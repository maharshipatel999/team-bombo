using UnityEngine;
using System.Collections;

public class GlassFixPos : MonoBehaviour {

	public RectTransform glassCanvas;
	public RectTransform panelTransform;

	// Use this for initialization
	void Start () {
		float newX = (glassCanvas.transform.position.x * 2 ) - 100;
		float newY = (glassCanvas.transform.position.y * 2 ) - 45;
		Debug.Log (newX);
		Debug.Log (newY);
		panelTransform.transform.position = new Vector3 (newX, newY, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}