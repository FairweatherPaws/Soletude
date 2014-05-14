using UnityEngine;
using System.Collections;

public class RunNGunControls : MonoBehaviour {

	private float jumpTimer = -1;
	private float speed = 1;
	private bool triggerRot = false;
	private float cooldown = 0;
	private float horizV = 0;
	public float runLim = 1.5f;
	public Camera mainCamera;
	public float angle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("Vertical") > 0 && jumpTimer < 0) { jumpTimer = 1f; speed = 2f;}
		float horizMove = Input.GetAxis ("Horizontal");
		if (horizV > -runLim && horizV < runLim) {
			if (horizMove > 0) {horizV += Time.deltaTime;}
			if (horizMove < 0) {horizV -=Time.deltaTime;}
		}
		if (horizMove == 0) {				
			if (horizV > 0) {horizV -= Time.deltaTime*3;}
			if (horizV < 0) {horizV += Time.deltaTime*3;}
		}
		if (horizV > runLim) {horizV = runLim;}
		if (horizV < -runLim) {horizV = -runLim;}
		if (jumpTimer > 0) { transform.Translate(0, 1f * speed, -horizV, Space.World); jumpTimer -= Time.deltaTime; speed -= Time.deltaTime*2; }
		else {transform.Translate(0, 0, -horizV, Space.World);}

		if (Input.GetAxis ("Jump") > 0 & cooldown < 0) 
		{ 
			transform.Rotate(0, 180, 0, Space.World);
			cooldown = 0.1f;

		}
		cooldown -= Time.deltaTime;

		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 0f;
		
		Vector3 objectPos = mainCamera.camera.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		Quaternion cheese = transform.rotation;
		
		angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		if ((angle < 90 && angle > -90) && cooldown < 0 ) { 
			cheese.y = 0;
			transform.rotation = cheese;
			transform.Rotate(0, 0, 0, Space.World);
			cooldown = 0.1f;
			Debug.Log("GoRight");

		}
		if ((angle > 90 || angle < -90) && cooldown < 0) {
			cheese.y = 180;
			transform.rotation = cheese;
			cooldown = 0.1f;
			Debug.Log("GoLeft");
		}
	}
}
