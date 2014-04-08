using UnityEngine;
using System.Collections;

public class ParticleRotate : MonoBehaviour {

	public int rotMulti;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, rotMulti*Time.deltaTime, 0);
	}
}
