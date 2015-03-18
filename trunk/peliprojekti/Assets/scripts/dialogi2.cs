using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogi2 : MonoBehaviour {
	public Text dialogue;
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("pacDot").Length == 0) { 
			dialogue.text = "What now?";}
		else {
			
		}
	}
}

