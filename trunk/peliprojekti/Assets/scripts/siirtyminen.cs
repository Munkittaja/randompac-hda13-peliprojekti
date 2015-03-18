using UnityEngine;
using System.Collections;

public class siirtyminen : MonoBehaviour {
	void Start () {
		if (GameObject.Find("pacdot")==null){ 
			Application.LoadLevel("Level2");
			float speed = 0.3f;}
		else {

		};
	}
}

