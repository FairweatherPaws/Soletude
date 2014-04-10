using UnityEngine;
using System.Collections;

public class ExploreSystem : MonoBehaviour {

//	0 null,
//	1-5 terran, 
//	6-10 jungle, 			featureName[] is defined by the relevant
//	11-15 ocean, 			entry in starArray[,] (starNumber, 9-18)
//	16-20 arid, 			
//	21-25 tundra, 			
//	26-30 desert, 
//	31-35 arctic, 
//	36-40 lava, 
//	41-45 barren, 
//	46-60 asteroid belt, 	planets 1-45 #45
//	61-115 gas giant		other bodies 46-120 #75
//	116-120 brown dwarf
//	121-127 artificial habitat
	private string[] featureName = {"",
		"tiny terran planet", "small terran planet", "medium terran planet", "large terran planet", "huge terran planet", 
		"tiny jungle planet", "small jungle planet", "medium jungle planet", "large jungle planet", "huge jungle planet", 
		"tiny ocean planet", "small ocean planet", "medium ocean planet", "large ocean planet", "huge ocean planet", 
		"tiny arid planet", "small arid planet", "medium arid planet", "large arid planet", "huge arid planet", 
		"tiny tundra planet", "small tundra planet", "medium tundra planet", "large tundra planet", "huge tundra planet", 
		"tiny desert planet", "small desert planet", "medium desert planet", "large desert planet", "huge desert planet", 
		"tiny arctic planet", "small arctic planet", "medium arctic planet", "large arctic planet", "huge arctic planet", 
		"tiny lava planet", "small lava planet", "medium lava planet", "large lava planet", "huge lava planet", 
		"tiny barren planet", "small barren planet", "medium barren planet", "large barren planet", "huge barren planet", 
		"asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", 
		"asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", 
		"asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", "asteroid belt", 
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"gas giant", "gas giant", "gas giant", "gas giant", "gas giant",
		"brown dwarf", "brown dwarf", "brown dwarf", "brown dwarf", "brown dwarf", 
		"shattered artificial planet", "artificial planet", "space habitat derelict", 
		"scattered Dyson ring", "intact Dyson ring", "scattered Dyson sphere", "intact Dyson sphere"};

	private string[] starType = {
		"Type 'M' flare star",                                         	// 0
		"Faint type 'M' red star",                                     	// 1
		"Type 'M' red star",                                           	// 2
		"Type 'K' orange star",                                        	// 3
		"Type 'G' yellow star",                                        	// 4
		"Type 'F' white star",                                         	// 5
		"Type 'A' hot white star",                                     	// 6
		"White dwarf star",                                            	// 7
		"Red giant star",                                              	// 8
		"Bright giant star",                                           	// 9
		"Type 'B' hot blue star",                                      	// 10
		"Supergiant star",                                             	// 11
		"Blue supergiant star",                                        	// 12
		"White hypergiant star",					   					// 13
		"Neutron star",													// 14
		"Pulsar"};														// 15

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
