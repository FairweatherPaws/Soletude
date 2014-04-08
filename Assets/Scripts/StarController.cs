using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarController : MonoBehaviour {

	private int[] starSpread =
	{
		0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 8, 8, 2, 5, 6, 8,11, 4, 1, 0, 0, 0, 0,
		0, 0, 6,11, 8, 9, 6,15,29,22,25,16, 6, 4, 0, 0, 0,
		0, 1, 8,24, 5,28,24,20,11,15, 7,12,23,15, 3, 0, 0,
		0, 6, 9,11,17,46,23,17,33,32,36,12,12,12, 9, 1, 0,
		0,17,28,17,30,26,24,49,50,33,29,17,19, 5,12, 3, 0,
		0,13,17,17,36,41,40,59,58,50,28,18,29,11, 2, 4, 0,
		0, 6,15,14,24,45,55,64,64,64,54,27,26,36,10, 1, 0,
		2, 6,18,28,14,51,57,64,99,54,59,38,18,31,11, 0, 0,
		5, 4,17,27,18,32,60,58,61,52,35,33,14,25, 9, 2, 0,
		0, 7,11,13,19,22,32,55,55,30,31,24,12,21, 5, 1, 0,
		0,11,20, 9,15,30,26,37,32,22,24,15,15,17, 8, 2, 0,
		0, 6, 9,19,14,12,10, 9,11,22,13, 7,11,11, 3, 0, 0,
		0, 0, 4,17,29,25,27,18,16,10, 5,11,14, 3, 0, 0, 0,
		0, 0, 2, 5, 6, 8,12,10, 4, 5,16,11, 6, 1, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 7, 1, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
	private int multiplier = 2;
	public GameObject starWhite, starRed, starBlue, starYellow, starDimWhite, starDimRed, starDimBlue, starDimYellow, ship; 
	public GameObject blankGlowWhite, blankGlowRed, blankGlowBlue, blankGlowYellow, blankGlowDimWhite, blankGlowDimRed, blankGlowDimBlue, blankGlowDimYellow;
	public int rightShift, downShift, starX, starY, starZ, sector, starNumber, xMin, xMax, yMin, yMax, zShift, spawnX, spawnY, spawnZ;
	public int[,] starArray;

	// Use this for initialization
	void Start () {
		sector = -1;
		starNumber = -1;
		starArray = new int[8060,5];

		spawnX = Random.Range(400, 800);
		spawnY = Random.Range(-100, 100);
		spawnZ = Random.Range (400, 800);
		GameObject playerShip;
		playerShip = Instantiate(ship, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity) as GameObject;
		
		foreach (int element in starSpread)
		{
			sector += 1;

			if (element > 0)
			{
				int starCount = element * multiplier;
				for (int i = 0; i < starCount; i++)
				{
					starNumber += 1;
					rightShift = 0;
					downShift = 0;
					xMin = 2;
					xMax = 2;
					yMin = 2;
					yMax = 2;
					if (starSpread[sector+1] < 8) {xMin -= 1;} 
					if (starSpread[sector-1] < 8) {xMax -= 1;} 
					if (sector > 16) {
						if (starSpread[sector-16] < 8) {
							yMin -= 1;
						} 
					} 
					else {yMin -= 1;}
					if (starSpread[sector+16] < 8) {yMax -= 1;}
//					if (starSpread[sector-8] == 0) {xMin -= 1; yMin -= 1;}
//					if (starSpread[sector-6] == 0) {xMin -= 1; yMax -= 1;}
//					if (starSpread[sector+6] == 0) {xMax -= 1; yMin -= 1;}
//					if (starSpread[sector+8] == 0) {xMax -= 1; yMax -= 1;}
					int starX = (Random.Range(-32*xMin, 32*xMax)+Random.Range(-32*xMin, 32*xMax));
					int starY = (Random.Range(-32*yMin, 32*yMax)+Random.Range(-32*yMin, 32*yMax));
					int extend = Random.Range (0, 10);
					if (extend < 6) {zShift = 1;} 
					if (extend > 5 && extend < 8) {zShift = 2;}
					if (extend > 7 && extend < 9) {zShift = 3;}
					if (extend > 8 && extend < 10) {zShift = 4;}
					if (element > 24) {zShift += 1;}
					if (element > 36) {zShift += 1;}
					if (element > 46) {zShift += 1;}
					if (element > 54) {zShift += 1;}
					if (element > 60) {zShift += 1;}

					int starZ = Random.Range (-16-16*zShift, 16+16*zShift);
					for (int j = 0; j < 17; j++)
					{
						if ((sector + j) % 17 == 0) {rightShift = j-9; break;}
					}

//					if (sector % 17 == 0) {rightShift = -3;} 
//					if ((sector+1) % 17 == 0) {rightShift = -2;}
//					if ((sector+2) % 17 == 0) {rightShift = -1;}
//					if ((sector+3) % 17 == 0) {rightShift = 0;}
//					if ((sector+4) % 17 == 0) {rightShift = 1;}
//					if ((sector+5) % 16 == 0) {rightShift = 2;}
//					if ((sector+6) % 16 == 0) {rightShift = 3;}

					for (int j = 0; j < 17; j++)
					{
						if (sector - j * 17 <= 0) {downShift = j-9; break;}
					}

//					if (sector >= 0 && sector < 7) {downShift = -4;}
//					if (sector >= 7 && sector < 14) {downShift = -3;}
//					if (sector >= 14 && sector < 21) {downShift = -2;}
//					if (sector >= 21 && sector < 28) {downShift = -1;}
//					if (sector >= 28 && sector < 35) {downShift = 0;}
//					if (sector >= 35 && sector < 42) {downShift = 1;}
//					if (sector >= 42 && sector < 49) {downShift = 2;}
//					if (sector >= 49 && sector < 56) {downShift = 3;}
//					if (sector >= 56 && sector < 63) {downShift = 4;}
					float sectorCheck = Mathf.Sqrt ((rightShift*rightShift)+(downShift*downShift));
					rightShift *= 128;
					downShift *= 128;
					starX += rightShift;
					starY += downShift;
					float testLength = (spawnX - starX)*(spawnX - starX)+(spawnY-starZ)*(spawnY-starZ)+(spawnZ-starY)*(spawnZ-starY);
					testLength = Mathf.Sqrt(testLength);
					int woob = Random.Range(2, 20);
					woob -= (int)sectorCheck;

					if (woob > 6) {starArray[starNumber,4] = 0;} // white star
					if (woob < 0) {starArray[starNumber,4] = 1;} // red star		
					if (woob == 0) {starArray[starNumber,4] = 2;} // blue star
					if (woob > 0 && woob < 7) {starArray[starNumber,4] = 3;} // yellow star

					int dimmer = Random.Range (0, 3);
					if (dimmer == 1) {starArray[starNumber,4] += 3;} // dims stars -- larger, less intense halo
					if (testLength < 200)
					{
						GameObject newStar;
						if (starArray[starNumber,4] == 0) {newStar = Instantiate(starWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 1) {newStar = Instantiate(starRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 2) {newStar = Instantiate(starBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 3) {newStar = Instantiate(starYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 4) {newStar = Instantiate(starDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 5) {newStar = Instantiate(starDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 6) {newStar = Instantiate(starDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						//						StarScript Script1 = newStar.GetComponent<StarScript>();
//						Script1.starX = starX;
//						Script1.starY = starZ;
//						Script1.starZ = starY;
//						Script1.sector = sector;
					}
					else
					{
						if (starNumber % 3 == 0) {
							GameObject newStar;

							if (starArray[starNumber,4] == 0) {newStar = Instantiate(blankGlowWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 1) {newStar = Instantiate(blankGlowRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 2) {newStar = Instantiate(blankGlowBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 3) {newStar = Instantiate(blankGlowYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 4) {newStar = Instantiate(blankGlowDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 5) {newStar = Instantiate(blankGlowDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
							if (starArray[starNumber,4] == 6) {newStar = Instantiate(blankGlowDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						}
					}

					// starnumber, starX, starY, starZ, starType
					starArray[starNumber,0] = starNumber;
					starArray[starNumber,1] = starX;
					starArray[starNumber,2] = starZ;
					starArray[starNumber,3] = starY;




					
				}

			}
		}
	


	}
	
	// Update is called once per frame
	void Update () {


	}
}
