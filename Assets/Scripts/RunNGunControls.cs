using UnityEngine;
using System.Collections;

public class RunNGunControls : MonoBehaviour {

	private float jumpTimer = 0;
	private float speed = 1;
	private bool triggerRot = false;
	private float cooldown = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetAxis ("Vertical") > 0) { jumpTimer = 1f; speed = 1f;}
		float horizMove = Input.GetAxis ("Horizontal");
		if (jumpTimer > 0) { transform.Translate(0, 0.5f * speed, -horizMove * 2f); jumpTimer -= Time.deltaTime; speed -= Time.deltaTime/2; }
		else {transform.Translate(0, 0, -horizMove * 2f);}

	}
}
