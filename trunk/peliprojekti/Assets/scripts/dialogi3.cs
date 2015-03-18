using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogi3 : MonoBehaviour {
	public Text dialogue;
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("pacDot").Length == 0) { 
			dialogue.text = "You are stuck in a maze.";}
		else {
			
		}
	}
}
