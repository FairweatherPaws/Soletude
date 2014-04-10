using UnityEngine;
using System.Collections;

public class GridHighlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver () {

		renderer.enabled = true;

	}

	void OnMouseExit () {

		renderer.enabled = false;

	}
}
