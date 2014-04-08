using UnityEngine;
using System.Collections;

public class RotCam : MonoBehaviour {

	private float speed = 40f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float Yrotation = Input.GetAxis("Mouse Y") * speed * 5;
		float Xrotation = Input.GetAxis("Mouse X") * speed * 5;
		float Zrotation = Input.GetAxis("Rotate Sideways") * speed * 5;
		float Xtranslation = Input.GetAxis ("Horizontal") * speed * 10;
		float Ztranslation = Input.GetAxis ("Vertical") * speed * 10;
		float Ytranslation = Input.GetAxis ("Up Shift") * speed * 10;
		Xtranslation *= Time.deltaTime;
		Ytranslation *= Time.deltaTime;
		Ztranslation *= Time.deltaTime;
		Yrotation *= Time.deltaTime;
		Xrotation *= Time.deltaTime;
		Zrotation *= Time.deltaTime;

		transform.Rotate(-Yrotation, Xrotation, -Zrotation);
		transform.Translate(Xtranslation, Ytranslation, Ztranslation);

	
	}
}
