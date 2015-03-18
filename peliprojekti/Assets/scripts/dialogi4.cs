using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dialogi4 : MonoBehaviour {
	public Text dialogue;
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("pacDot").Length == 0) { 
			dialogue.text = "endlessly running around" ;}
		else {
			
		}
	}
}
