using UnityEngine;
using System.Collections;

public class RNGshooting : MonoBehaviour {

	public float startValue;
	public Transform bullet;
	public Camera mainCamera;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0)) 
		{
			startValue -= Time.deltaTime;
			if (startValue < 0) 
			{
				Vector3 mousePos = Input.mousePosition;
				mousePos.z = 0f;
				
				Vector3 objectPos = mainCamera.camera.WorldToScreenPoint (transform.position);
				mousePos.x = mousePos.x - objectPos.x;
				mousePos.y = mousePos.y - objectPos.y;
				
				float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

				GameObject newBullet;
				newBullet = Instantiate(bullet, this.transform.position, Quaternion.Euler(new Vector3(angle, 0, 0))) as GameObject;




				startValue = 1f;
			}
		}
	
	}
}
