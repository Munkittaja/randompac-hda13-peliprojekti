using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour {
	public float speed = 0.4f;
	Vector2 dest = Vector2.zero;
	
	void Start() {
		dest = transform.position;
	}
	
	void FixedUpdate() {
		// Move closer to Destination
		//Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
		//rigidbody2D.MovePosition(p);
	
		dest = Vector2.zero;
		
			if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
				dest = Vector2.up*speed;
			if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
			dest = Vector2.right*speed;
			if (Input.GetKey(KeyCode.UpArrow) && valid(-Vector2.down))
			dest = Vector2.down*speed;
			if (Input.GetKey(KeyCode.RightArrow) && valid(-Vector2.left))
			dest = Vector2.left*speed;
			rigidbody2D.velocity = dest;

	
	
	}
	
	bool valid(Vector2 dir) {
		// Cast Line from 'next to Pac-Man' to 'Pac-Man'
		Vector2 pos = transform.position;
		RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
		return (hit.collider == collider2D);
	}
}
