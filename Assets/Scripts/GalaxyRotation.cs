using UnityEngine;
using System.Collections;

public class GalaxyRotation : MonoBehaviour {

	private int speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {speed++;}
	transform.Rotate(0, Time.deltaTime * speed, 0);
	}
}
