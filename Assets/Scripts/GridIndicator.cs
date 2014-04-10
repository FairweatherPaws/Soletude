using UnityEngine;
using System.Collections;

public class GridIndicator : MonoBehaviour {

	public GameObject gridInd;
	private int rightShift, downShift;

	// Use this for initialization
	void Start () {

		for (int i = 1; i < 1025; i++)
		{
	
			for (int j = 0; j < 33; j++)
			{
				if ((i + j) % 32 == 0) {rightShift = j-16; break;}
			}

			for (int k = 0; k < 33; k++)
			{
				if (i - k * 32 <= 0) {downShift = k-16; break;}
			}
			GameObject woobwoob = null;
			rightShift *= 1280;
			downShift *= 1280;
			woobwoob = Instantiate (gridInd, new Vector3(rightShift-50, 530, downShift-1330), Quaternion.identity) as GameObject;
			woobwoob.transform.parent = this.transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
