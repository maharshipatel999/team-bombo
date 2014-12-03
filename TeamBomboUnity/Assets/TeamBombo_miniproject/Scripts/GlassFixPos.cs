using UnityEngine;
using System.Collections;

public class GlassFixPos : MonoBehaviour {

	public RectTransform glassCanvas;
	public RectTransform panelTransform;
	public GameObject ImageObject, TextObject;
	RectTransform ImageTransform, TextTransform;
	UnityEngine.UI.Text TimeField;

	// Use this for initialization
	void Start () {
		ImageTransform = ImageObject.GetComponent ("Transform") as RectTransform;
		TextTransform = TextObject.GetComponent ("Transform") as RectTransform;
		TimeField = TextObject.GetComponent ("Text") as UnityEngine.UI.Text;
 
		float newX = (glassCanvas.transform.position.x * 2 ) - 125;
		float newY = (glassCanvas.transform.position.y * 2 ) - 75;
		panelTransform.transform.position = new Vector3 (newX, newY, 0);
		ImageTransform.transform.position = new Vector3 (newX - 50, newY - 35, 0);
		TextTransform.transform.position = new Vector3 (newX - 50, newY + 50, 0);
	}
	
	// Update is called once per frame
	void Update () {
		TimeField.text = System.DateTime.Now.TimeOfDay.ToString ();;
	}
}