using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class siirtyminen : MonoBehaviour {
	public Text dialogue;
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("pacDot").Length == 0) { 
		dialogue.text = "You have won.";}
		else {

		}
	}
}

