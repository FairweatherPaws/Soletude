using UnityEngine;
using System.Collections;

public class indicatorLightMotion : MonoBehaviour {
	public float offset, amount;
	// Use this for initialization
	void Start () {
		amount = 0.01f;
	}
	
	// Update is called once per frame
	void Update () {

		offset += amount;
		renderer.material.mainTextureOffset = new Vector2(0, offset);
	}
}
