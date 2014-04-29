using UnityEngine;
using System.Collections;

public class BulletFlight : MonoBehaviour {

	private float lifeSpan = 3f;

	// Use this for initialization

	void Awake () {

		this.rigidbody.AddForce(-transform.forward * 3000);

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		lifeSpan -= Time.deltaTime;
		if (lifeSpan < 0) {Destroy(this.gameObject);}
	}

	void OnTriggerEnter (Collider collDetect) {
		
		if (collDetect) {

			Destroy(this.gameObject);
			
			// damage dealing here
			
		}
	}
}
