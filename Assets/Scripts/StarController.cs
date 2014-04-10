using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarController : MonoBehaviour {

//	private int[] starSpread =
//	{
//		0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
//		0, 0, 0, 0, 8, 8, 2, 5, 6, 8,11, 4, 1, 0, 0, 0, 0,
//		0, 0, 6,11, 8, 9, 6,15,29,22,25,16, 6, 4, 0, 0, 0,
//		0, 1, 8,24, 5,28,24,20,11,15, 7,12,23,15, 3, 0, 0,
//		0, 6, 9,11,17,46,23,17,33,32,36,12,12,12, 9, 1, 0,
//		0,17,28,17,30,26,24,49,50,33,29,17,19, 5,12, 3, 0,
//		0,13,17,17,36,41,40,59,58,50,28,18,29,11, 2, 4, 0,
//		0, 6,15,14,24,45,55,64,64,64,54,27,26,36,10, 1, 0,
//		2, 6,18,28,14,51,57,64,99,54,59,38,18,31,11, 0, 0,
//		5, 4,17,27,18,32,60,58,61,52,35,33,14,25, 9, 2, 0,
//		0, 7,11,13,19,22,32,55,55,30,31,24,12,21, 5, 1, 0,
//		0,11,20, 9,15,30,26,37,32,22,24,15,15,17, 8, 2, 0,
//		0, 6, 9,19,14,12,10, 9,11,22,13, 7,11,11, 3, 0, 0,
//		0, 0, 4,17,29,25,27,18,16,10, 5,11,14, 3, 0, 0, 0,
//		0, 0, 2, 5, 6, 8,12,10, 4, 5,16,11, 6, 1, 0, 0, 0,
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 7, 1, 0, 0, 0, 0, 0,
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

//	private int [] starSpread = 
//		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 17, 6, 2, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 5, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 63, 57, 21, 19, 0, 2, 3, 3, 0, 0, 0, 2, 7, 22, 3, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 59, 131, 23, 0, 4, 10, 22, 30, 4, 15, 5, 1, 48, 56, 10, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 10, 10, 1, 25, 44, 80, 102, 35, 37, 29, 23, 52, 33, 74, 31, 4, 32, 31, 3, 1, 1, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 1, 18, 106, 66, 20, 19, 14, 63, 125, 34, 6, 40, 73, 127, 87, 72, 20, 1, 0, 12, 24, 20, 4, 44, 8, 0, 0, 0, 
//		0, 0, 0, 0, 0, 11, 55, 22, 1, 5, 29, 8, 2, 0, 7, 6, 56, 61, 55, 78, 35, 9, 0, 41, 39, 73, 26, 38, 1, 0, 0, 0, 
//		0, 0, 1, 0, 0, 0, 0, 0, 5, 11, 86, 110, 67, 48, 11, 14, 2, 19, 48, 74, 90, 26, 15, 59, 23, 21, 59, 92, 2, 0, 0, 0, 
//		0, 0, 8, 0, 6, 18, 0, 0, 74, 53, 38, 130, 177, 189, 104, 113, 60, 9, 2, 25, 20, 14, 20, 9, 3, 16, 49, 130, 38, 0, 0, 0, 
//		0, 0, 0, 10, 3, 3, 15, 62, 144, 171, 98, 63, 158, 229, 181, 160, 188, 123, 49, 22, 14, 50, 162, 61, 28, 16, 57, 151, 45, 0, 0, 0, 
//		0, 0, 0, 2, 1, 4, 91, 174, 136, 212, 103, 25, 81, 110, 164, 146, 205, 243, 186, 141, 26, 123, 115, 26, 4, 2, 26, 27, 1, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 60, 87, 52, 135, 66, 70, 69, 77, 178, 181, 193, 219, 252, 201, 68, 81, 104, 16, 0, 0, 22, 120, 30, 0, 0, 0, 
//		0, 0, 0, 0, 0, 13, 41, 59, 45, 7, 6, 101, 175, 227, 252, 230, 214, 252, 251, 241, 131, 106, 113, 55, 25, 4, 58, 98, 29, 7, 0, 0, 
//		0, 0, 0, 0, 1, 18, 56, 95, 9, 29, 108, 199, 250, 252, 252, 252, 252, 252, 236, 194, 195, 174, 155, 86, 32, 3, 42, 35, 8, 9, 0, 0, 
//		0, 0, 0, 2, 13, 52, 23, 17, 4, 81, 201, 217, 175, 234, 252, 252, 252, 252, 246, 220, 240, 237, 175, 77, 3, 0, 39, 14, 0, 0, 0, 0, 
//		0, 0, 0, 14, 67, 90, 8, 2, 43, 130, 206, 206, 205, 247, 252, 252, 252, 252, 226, 240, 228, 195, 188, 54, 16, 2, 18, 5, 0, 0, 0, 0, 
//		0, 0, 0, 0, 67, 111, 17, 22, 78, 163, 191, 142, 187, 252, 252, 252, 252, 252, 248, 247, 224, 195, 125, 35, 2, 33, 65, 20, 0, 0, 0, 0, 
//		0, 0, 0, 3, 54, 60, 93, 11, 24, 139, 139, 90, 151, 252, 252, 252, 245, 222, 245, 236, 138, 101, 35, 22, 7, 79, 52, 0, 0, 0, 0, 0, 
//		0, 0, 0, 35, 81, 10, 13, 0, 41, 188, 134, 47, 109, 224, 252, 252, 198, 151, 172, 132, 65, 57, 57, 95, 86, 34, 12, 0, 0, 0, 12, 0, 
//		0, 0, 0, 55, 83, 16, 1, 0, 53, 235, 160, 13, 39, 193, 237, 240, 245, 246, 145, 95, 85, 75, 59, 89, 72, 3, 0, 0, 11, 19, 19, 0, 
//		0, 0, 0, 25, 100, 68, 6, 0, 35, 154, 123, 60, 5, 95, 192, 157, 233, 194, 101, 113, 134, 77, 48, 49, 17, 0, 0, 5, 43, 21, 0, 0, 
//		0, 0, 0, 23, 78, 38, 4, 20, 7, 17, 46, 21, 32, 26, 75, 146, 219, 162, 126, 136, 130, 62, 35, 36, 17, 0, 0, 0, 3, 16, 1, 0, 
//		0, 0, 0, 0, 4, 1, 2, 4, 3, 14, 25, 14, 31, 40, 31, 45, 52, 84, 102, 49, 11, 37, 22, 1, 0, 2, 16, 34, 20, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 43, 37, 10, 8, 44, 57, 63, 105, 72, 49, 7, 44, 11, 15, 15, 7, 20, 11, 0, 6, 21, 39, 21, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 76, 68, 17, 0, 5, 63, 107, 64, 52, 112, 47, 36, 14, 23, 19, 0, 21, 21, 1, 26, 18, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 27, 71, 18, 0, 0, 5, 10, 23, 136, 171, 119, 80, 50, 17, 37, 51, 35, 35, 2, 25, 7, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 1, 11, 26, 2, 0, 0, 1, 7, 62, 93, 88, 87, 127, 68, 25, 80, 28, 7, 0, 1, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 3, 18, 27, 5, 0, 0, 17, 64, 54, 33, 32, 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 13, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
//		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
	private int [] starSpread = 
	{
		0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 3, 10, 4, 11, 1, 0, 1, 2, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
		0, 0, 0, 0, 1, 1, 2, 11, 33, 27, 8, 3, 0, 0, 0, 1, 2, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
		0, 0, 0, 0, 0, 5, 27, 37, 63, 33, 1, 2, 21, 4, 10, 6, 5, 7, 6, 9, 5, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
		0, 0, 0, 32, 55, 48, 64, 42, 13, 4, 13, 16, 20, 19, 31, 29, 34, 33, 32, 21, 16, 9, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 
		0, 0, 0, 7, 62, 108, 69, 36, 8, 14, 16, 13, 38, 40, 34, 42, 20, 18, 36, 44, 19, 18, 13, 5, 1, 0, 0, 8, 0, 0, 0, 0, 
		0, 0, 0, 1, 22, 75, 47, 11, 6, 4, 4, 24, 38, 24, 31, 17, 17, 7, 9, 5, 5, 18, 34, 42, 17, 2, 0, 0, 0, 0, 0, 0, 
		0, 0, 0, 17, 79, 87, 41, 8, 6, 10, 19, 54, 55, 17, 27, 54, 74, 69, 54, 55, 31, 8, 29, 47, 41, 20, 3, 0, 0, 0, 0, 0, 
		0, 0, 1, 19, 63, 62, 47, 8, 3, 13, 65, 66, 72, 76, 112, 122, 139, 113, 100, 121, 98, 71, 26, 10, 28, 38, 11, 1, 0, 0, 0, 0, 
		1, 0, 6, 43, 78, 64, 39, 2, 1, 47, 85, 93, 113, 108, 105, 71, 47, 40, 38, 64, 94, 136, 116, 53, 16, 14, 21, 9, 0, 0, 0, 0, 
		0, 0, 21, 70, 77, 50, 24, 3, 11, 44, 82, 130, 123, 62, 41, 34, 41, 27, 20, 28, 42, 63, 116, 118, 44, 4, 5, 10, 1, 0, 0, 0, 
		0, 1, 31, 67, 77, 48, 21, 13, 22, 61, 123, 115, 58, 41, 57, 42, 44, 55, 43, 29, 21, 30, 48, 131, 106, 32, 1, 14, 19, 0, 0, 0, 
		0, 3, 35, 74, 64, 33, 20, 20, 34, 88, 136, 96, 59, 46, 34, 54, 108, 162, 148, 81, 39, 47, 39, 63, 115, 73, 18, 3, 49, 2, 0, 0, 
		0, 0, 25, 63, 61, 28, 17, 34, 49, 116, 112, 62, 66, 43, 71, 113, 157, 235, 209, 145, 79, 59, 74, 51, 102, 110, 39, 5, 4, 2, 0, 0, 
		1, 2, 36, 71, 54, 22, 17, 35, 79, 108, 91, 70, 45, 74, 91, 124, 205, 246, 195, 136, 135, 67, 79, 72, 62, 118, 69, 9, 1, 0, 0, 0, 
		0, 5, 70, 81, 52, 28, 28, 41, 94, 153, 99, 63, 71, 106, 116, 222, 244, 230, 165, 117, 147, 67, 62, 76, 40, 92, 95, 29, 1, 0, 0, 0, 
		2, 2, 11, 43, 29, 34, 36, 47, 104, 173, 156, 100, 123, 155, 225, 254, 234, 195, 128, 97, 143, 72, 44, 63, 54, 54, 107, 35, 2, 0, 0, 0, 
		0, 0, 11, 65, 25, 37, 52, 63, 104, 136, 154, 168, 173, 211, 239, 208, 151, 135, 84, 55, 108, 105, 37, 50, 62, 39, 84, 61, 5, 0, 0, 0, 
		1, 0, 1, 43, 38, 65, 66, 79, 93, 114, 143, 184, 214, 231, 169, 129, 122, 82, 55, 54, 78, 123, 27, 38, 61, 42, 59, 84, 17, 0, 0, 0, 
		1, 0, 1, 19, 46, 56, 80, 80, 81, 94, 114, 161, 204, 182, 114, 103, 72, 63, 41, 56, 80, 88, 34, 36, 60, 51, 72, 42, 15, 0, 0, 0, 
		1, 0, 0, 13, 57, 50, 73, 80, 92, 92, 89, 81, 113, 120, 65, 46, 75, 47, 50, 65, 91, 76, 43, 40, 52, 59, 63, 48, 20, 3, 0, 0, 
		0, 0, 0, 5, 39, 65, 42, 64, 81, 79, 59, 56, 75, 87, 77, 81, 73, 48, 59, 78, 82, 55, 32, 26, 46, 61, 56, 31, 9, 13, 1, 0, 
		0, 0, 2, 2, 6, 46, 71, 63, 57, 60, 52, 35, 36, 33, 30, 31, 50, 64, 82, 95, 67, 36, 16, 14, 41, 56, 76, 52, 9, 2, 0, 0, 
		1, 1, 14, 17, 13, 12, 44, 57, 53, 42, 58, 63, 65, 66, 71, 81, 74, 92, 95, 82, 59, 35, 21, 21, 63, 75, 92, 49, 11, 19, 1, 0, 
		0, 0, 1, 25, 46, 31, 26, 26, 52, 59, 75, 81, 84, 99, 101, 96, 87, 73, 58, 42, 55, 55, 20, 46, 65, 129, 104, 23, 22, 69, 1, 0, 
		0, 0, 0, 0, 5, 10, 19, 16, 16, 13, 17, 32, 55, 67, 51, 43, 30, 42, 38, 60, 63, 19, 18, 50, 104, 82, 18, 3, 10, 55, 1, 0, 
		0, 0, 0, 0, 0, 0, 1, 3, 7, 11, 10, 9, 6, 16, 20, 27, 37, 49, 51, 76, 27, 9, 43, 70, 112, 50, 7, 2, 5, 3, 0, 0, 
		0, 0, 0, 0, 0, 0, 0, 4, 6, 13, 21, 39, 35, 50, 42, 56, 61, 65, 40, 17, 12, 41, 67, 116, 112, 20, 3, 2, 22, 1, 0, 0, 
		0, 0, 0, 0, 2, 0, 1, 0, 1, 3, 3, 4, 13, 19, 29, 22, 19, 21, 26, 16, 43, 64, 83, 110, 39, 6, 4, 3, 3, 0, 0, 0, 
		0, 0, 0, 0, 0, 2, 5, 2, 0, 2, 0, 3, 1, 1, 0, 2, 4, 11, 13, 22, 47, 73, 66, 19, 4, 7, 7, 1, 0, 0, 0, 0, 
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6, 2, 2, 1, 2, 4, 6, 11, 33, 41, 33, 8, 8, 2, 41, 29, 0, 0, 0, 0, 0, 
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5, 4, 5, 5, 2, 3, 5, 8, 3, 1, 11, 1, 1, 15, 32, 21, 0, 0, 0, 0, 0, 
		0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 8, 1, 3, 3, 0, 0, 0, 0, 0, 0, 7, 49, 5, 0, 0, 0, 0, 0, 0
	};

	private int multiplier = 32;
	public GameObject starWhite, starRed, starBlue, starYellow, starDimWhite, starDimRed, starDimBlue, starDimYellow, ship, sparkler; 
	public GameObject blankGlowWhite, blankGlowRed, blankGlowBlue, blankGlowYellow, blankGlowDimWhite, blankGlowDimRed, blankGlowDimBlue, blankGlowDimYellow;
	public int rightShift, downShift, starX, starY, starZ, sector, starNumber, xMin, xMax, yMin, yMax, zShift, spawnX, spawnY, spawnZ, sparklerCount;
	public int[,] starArray;

	// Use this for initialization
	void Start () {
		sector = -1;
		starNumber = -1;
		sparklerCount = 0;
		starArray = new int[1225825,29];

		spawnX = Random.Range(15000, 15720);
		spawnY = Random.Range(0, 1000);
		spawnZ = Random.Range (15000, 15720);
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
					if (starSpread[sector+1] < 32) {xMin -= 1;} 
					if (starSpread[sector-1] < 32) {xMax -= 1;} 
					if (sector > 32) {
						if (starSpread[sector-32] < 32) {
							yMin -= 1;
						} 
					} 
					else {yMin -= 1;}
					if (sector < 992) {
						if (starSpread[sector+32] < 32) {
							yMin -= 1;
						} 
					} 
					else {yMin -= 1;}
					// if (starSpread[sector+32] < 32) {yMax -= 1;}
//					if (starSpread[sector-8] == 0) {xMin -= 1; yMin -= 1;}
//					if (starSpread[sector-6] == 0) {xMin -= 1; yMax -= 1;}
//					if (starSpread[sector+6] == 0) {xMax -= 1; yMin -= 1;}
//					if (starSpread[sector+8] == 0) {xMax -= 1; yMax -= 1;}
					int starX = (Random.Range(-320*xMin, 320*xMax)+Random.Range(-320*xMin, 320*xMax));
					int starY = (Random.Range(-320*yMin, 320*yMax)+Random.Range(-320*yMin, 320*yMax));
					int starManipX = starX / 10 + 32;
					int starManipY = starY / 10 + 32;

					int extend = Random.Range (0, 10);
					if (extend < 6) {zShift = 1;} 
					if (extend > 5 && extend < 8) {zShift = 2;}
					if (extend > 7 && extend < 9) {zShift = 3;}
					if (extend > 8 && extend < 10) {zShift = 4;}
					if (element > 70) {zShift += 1;}
					if (element > 120) {zShift += 1;}
					if (element > 160) {zShift += 1;}
					if (element > 200) {zShift += 1;}
					if (element > 240) {zShift += 1;}

					int starZ = Random.Range (-160-160*zShift, 160+160*zShift);

					int starManipZ = starZ / 10 + 32;


					for (int j = 0; j < 32; j++)
					{
						if ((sector + j) % 32 == 0) {rightShift = j-16; break;}
					}

//					if (sector % 17 == 0) {rightShift = -3;} 
//					if ((sector+1) % 17 == 0) {rightShift = -2;}
//					if ((sector+2) % 17 == 0) {rightShift = -1;}
//					if ((sector+3) % 17 == 0) {rightShift = 0;}
//					if ((sector+4) % 17 == 0) {rightShift = 1;}
//					if ((sector+5) % 16 == 0) {rightShift = 2;}
//					if ((sector+6) % 16 == 0) {rightShift = 3;}

					for (int j = 0; j < 32; j++)
					{
						if (sector - j * 32 <= 0) {downShift = j-16; break;}
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
					rightShift *= 1280;
					downShift *= 1280;
					starX += rightShift;
					starY += downShift;
					float testLength = (spawnX - starX)*(spawnX - starX)+(spawnY-starZ)*(spawnY-starZ)+(spawnZ-starY)*(spawnZ-starY);
					testLength = Mathf.Sqrt(testLength);
					int woob = Random.Range(7, 30);
					woob -= (int)sectorCheck;


					if (woob > 6) {starArray[starNumber,4] = 0;} // white star
					if (woob < 0) {starArray[starNumber,4] = 1;} // red star		
					if (woob == 0) {starArray[starNumber,4] = 2;} // blue star
					if (woob > 0 && woob < 7) {starArray[starNumber,4] = 3;} // yellow star

					int dimmer = Random.Range (0, 3);
					if (dimmer == 1) {starArray[starNumber,4] += 3;} // dims stars -- larger, less intense halo

//					else {
//					if (testLength < 200 && starNumber % 8 == 0)
//						{
//							GameObject newStar;
//							if (starArray[starNumber,4] == 0) {newStar = Instantiate(blankGlowWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 1) {newStar = Instantiate(blankGlowRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 2) {newStar = Instantiate(blankGlowBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 3) {newStar = Instantiate(blankGlowYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 4) {newStar = Instantiate(blankGlowDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 5) {newStar = Instantiate(blankGlowDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							if (starArray[starNumber,4] == 6) {newStar = Instantiate(blankGlowDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//						}
//					}

//					else {
//						if (element > 60) {
//							if (starNumber % 3200 == 0) {
//								GameObject newStar;
//								newStar = Instantiate(sparkler, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;
//								sparklerCount++;
//							}
//						}
//						else {
//
//							if (starNumber % 800 == 0) {
//								GameObject newStar;
//								newStar = Instantiate(sparkler, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;
//								sparklerCount++;
//							}
//						}
//
//
//					}

//					else
//					{
//						if (element > 100) {
//							if (starNumber % 48 == 0) {
//								GameObject newStar;
//
//								if (starArray[starNumber,4] == 0) {newStar = Instantiate(blankGlowWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 1) {newStar = Instantiate(blankGlowRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 2) {newStar = Instantiate(blankGlowBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 3) {newStar = Instantiate(blankGlowYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 4) {newStar = Instantiate(blankGlowDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 5) {newStar = Instantiate(blankGlowDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 6) {newStar = Instantiate(blankGlowDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							}
//						}
//						else {
//							if (starNumber % 16 == 0) {
//								GameObject newStar;
//								
//								if (starArray[starNumber,4] == 0) {newStar = Instantiate(blankGlowWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 1) {newStar = Instantiate(blankGlowRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 2) {newStar = Instantiate(blankGlowBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 3) {newStar = Instantiate(blankGlowYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 4) {newStar = Instantiate(blankGlowDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 5) {newStar = Instantiate(blankGlowDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//								if (starArray[starNumber,4] == 6) {newStar = Instantiate(blankGlowDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
//							}
//						}
//					}
					int artOfInt = Random.Range(0, 100);
					int artOfInt0 = Random.Range(1,64);
					int artOfInt1 = 0;
					int artOfInt2 = 0;
					int artOfInt3 = 0;
					int artOfInt4 = 0;
					int artOfInt5 = 0;
					int artOfInt6 = 0;
					int artOfInt7 = 0;
					int artOfInt8 = 0;
					int artOfInt9 = 0;

					int artModif0 = Random.Range(1,16);
					int artModif1 = 0;
					int artModif2 = 0;
					int artModif3 = 0;
					int artModif4 = 0;
					int artModif5 = 0;
					int artModif6 = 0;
					int artModif7 = 0;
					int artModif8 = 0;
					int artModif9 = 0;

					if (artOfInt > 25) {artOfInt1 = Random.Range(0,64); artModif1 = Random.Range(1,16);}
					else {artOfInt1 = 0; artModif1 = 0;}
					if (artOfInt > 43) {artOfInt2 = Random.Range(1,64); artModif2 = Random.Range(1,16);}
					else {artOfInt2 = 0; artModif2 = 0;}
					if (artOfInt > 50) {artOfInt3 = Random.Range(1,64); artModif3 = Random.Range(1,16);}
					else {artOfInt3 = 0; artModif3 = 0;}
					if (artOfInt > 57) {artOfInt4 = Random.Range(1,64); artModif4 = Random.Range(1,16);}
					else {artOfInt4 = 0; artModif4 = 0;}
					if (artOfInt > 64) {artOfInt5 = Random.Range(1,64); artModif5 = Random.Range(1,16);}
					else {artOfInt5 = 0; artModif5 = 0;}
					if (artOfInt > 71) {artOfInt6 = Random.Range(1,64); artModif6 = Random.Range(1,16);}
					else {artOfInt6 = 0; artModif6 = 0;}
					if (artOfInt > 80) {artOfInt7 = Random.Range(1,64); artModif7 = Random.Range(1,16);}
					else {artOfInt7 = 0; artModif7 = 0;}
					if (artOfInt > 88) {artOfInt8 = Random.Range(1,64); artModif8 = Random.Range(1,16);}
					else {artOfInt8 = 0; artModif8 = 0;}
					if (artOfInt > 95) {artOfInt9 = Random.Range(1,64); artModif9 = Random.Range(1,16);}
					else {artOfInt9 = 0; artModif9 = 0;}
					// starnumber, starX, starY, starZ, starType
					starArray[starNumber,0] = starNumber;
					starArray[starNumber,1] = starX;
					starArray[starNumber,2] = starZ;
					starArray[starNumber,3] = starY;
					// starArray 4 = type;
					starArray[starNumber,5] = sector;
					starArray[starNumber,6] = starManipX; // These three are used for randomisation
					starArray[starNumber,7] = starManipY; // e.g. for star names and planets (maybe)
					starArray[starNumber,8] = starManipZ; //
					starArray[starNumber,9] = artOfInt0; // articles of interest: these include
					starArray[starNumber,10] = artOfInt1; // possible ruins and source of knowledge
					starArray[starNumber,11] = artOfInt2; // as well as resources for the
					starArray[starNumber,12] = artOfInt3; // improvement of the player's ship
					starArray[starNumber,13] = artOfInt4; // N.B.: these include planets as well 
					starArray[starNumber,14] = artOfInt5; // and as such are divided into useful
					starArray[starNumber,15] = artOfInt6; // categories detailed elsewhere
					starArray[starNumber,16] = artOfInt7;
					starArray[starNumber,17] = artOfInt8;
					starArray[starNumber,18] = artOfInt9;
					starArray[starNumber,19] = artModif0; // modifiers for said articles of interest;
					starArray[starNumber,20] = artModif1; // includes stuff such as special effects
					starArray[starNumber,21] = artModif2; // with article synergy (e.g. article 36
					starArray[starNumber,22] = artModif3; // + modifier 13 could produce a hostile
					starArray[starNumber,23] = artModif4; // encounter or something of that sort)
					starArray[starNumber,24] = artModif5; // N.B.: different categories of articles
					starArray[starNumber,25] = artModif6; // should synergise differently with the
					starArray[starNumber,26] = artModif7; // modifiers, for obvious reasons
					starArray[starNumber,27] = artModif8; // 
					starArray[starNumber,28] = artModif9;

					if (testLength < 1000)
					{
						GameObject newStar = null;
						if (starArray[starNumber,4] == 0) {newStar = Instantiate(starWhite, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 1) {newStar = Instantiate(starRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 2) {newStar = Instantiate(starBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 3) {newStar = Instantiate(starYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 4) {newStar = Instantiate(starDimRed, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 5) {newStar = Instantiate(starDimBlue, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}
						if (starArray[starNumber,4] == 6) {newStar = Instantiate(starDimYellow, new Vector3(starX, starZ, starY), Quaternion.Euler(45, 45, 45)) as GameObject;}

						StarScript Script1 = newStar.GetComponent<StarScript>();

						for (int k = 0; k < 28; k++)
						{
							Script1.starData[k] = starArray[starNumber, k];
						}

						//						Script1.starX = starX;
						//						Script1.starY = starZ;
						//						Script1.starZ = starY;
						//						Script1.sector = sector;
					}
				}

			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
