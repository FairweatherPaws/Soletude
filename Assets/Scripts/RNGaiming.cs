﻿using UnityEngine;
using System.Collections;

public class RNGaiming : MonoBehaviour {

	public Camera mainCamera;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 0f;
		
		Vector3 objectPos = mainCamera.camera.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(angle, 0, 0));
		
	}
}
