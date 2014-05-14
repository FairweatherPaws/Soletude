using UnityEngine;
using System.Collections;

public class RNGCamera : MonoBehaviour {
	public GameObject rngPC;
	public float zoom = 1f;
	private int trigger = 1;
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		float xPos = transform.position.x;
		float yPos = transform.position.y;
		float zPos = transform.position.z;

		float xPosPC = rngPC.transform.position.x;
		float yPosPC = rngPC.transform.position.y;
		float zPosPC = rngPC.transform.position.z;

		float xDel = (xPos + 150) - xPosPC;
		float yDel = (yPos - 50) - yPosPC;
		float zDel = zPos - zPosPC;

		if (yDel > 20 || yDel < -20) {zoom += Mathf.Abs(yDel/10000); trigger = 3;}
		else if (zDel > 30 || zDel < -30) {zoom += Mathf.Abs(zDel/10000); trigger = 3;}
		else {zoom = 0f; trigger = 1;}

		float yPosP = transform.position.y;
		float zPosP = transform.position.z;

		float xMove = -xDel * Time.deltaTime * trigger - zoom;
		if (transform.position.x < -200) {xMove = 0.5f;}

		transform.Translate(xMove, -yDel * Time.deltaTime, -zDel * Time.deltaTime, Space.World);
	}
}
