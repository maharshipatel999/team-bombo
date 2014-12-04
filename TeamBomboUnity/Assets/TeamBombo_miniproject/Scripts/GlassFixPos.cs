using UnityEngine;
using System.Collections;

public class GlassFixPos : MonoBehaviour {

	public RectTransform glassCanvas, panelTransform;
	public GameObject TextObject, TimeObject, AlertObject;
	RectTransform TextTransform, TimeTransform, AlertTransform;
	UnityEngine.UI.Text TimeField, TextField, AlertField;
	float DistanceTravelled;


	// Use this for initialization
	void Start () {
		TextTransform = TextObject.GetComponent ("Transform") as RectTransform;
		TimeTransform = TimeObject.GetComponent ("Transform") as RectTransform;
		AlertTransform = AlertObject.GetComponent ("Transform") as RectTransform;

		TimeField = TimeObject.GetComponent ("Text") as UnityEngine.UI.Text;
		TextField = TextObject.GetComponent ("Text") as UnityEngine.UI.Text;
		AlertField = AlertObject.GetComponent ("Text") as UnityEngine.UI.Text;


		float newX = (glassCanvas.transform.position.x * 2 ) - 125;
		float newY = (glassCanvas.transform.position.y * 2 ) - 75;
		panelTransform.transform.position = new Vector3 (newX, newY, 0);
		TextTransform.transform.position = new Vector3 (newX - 50, newY - 35, 0);
		TimeTransform.transform.position = new Vector3 (newX - 50, newY + 50, 0);
		AlertTransform.transform.position = new Vector3 (newX - 50, newY - 75, 0);

		DistanceTravelled = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		DistanceTravelled = DistanceTravelled + FPSInputController.instance.initialZ;
		TimeField.text = System.DateTime.Now.TimeOfDay.ToString();
		TextField.text = string.Format ("Distance Travelled: {0}\n Time Travelled: {1}",(int)DistanceTravelled/10,(int)Time.time);

		if ((Intersection.instance.transform.position.x < -150f) && (Intersection.instance.transform.position.x > -250f)
						&& (Intersection.instance.transform.position.z > -40f) && (Intersection.instance.transform.position.z < 100f)) {
						AlertField.text = "High Crime Area!";		
			Debug.Log ("High Crime Area!");
			
				} else {
			AlertField.text = "";		
		}

	}


}