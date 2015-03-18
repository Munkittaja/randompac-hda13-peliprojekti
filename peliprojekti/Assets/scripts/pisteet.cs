using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pisteet : MonoBehaviour {
	public static int score;
	public Text points;

	void Update(){
		points.text = score.ToString ();
	}
}
