using UnityEngine;
using System.Collections;

public class defeat : MonoBehaviour {

		void OnTriggerEnter2D(Collider2D co) {
			if (co.name == "pacman")
			Application.LoadLevel('defeat');
		}
	
