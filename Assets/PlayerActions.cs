using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerActions : MonoBehaviour {

	public float speed;
	public Rigidbody2D player;
	
	// FixedUpdate to call updates at fixed rate independent from frame rate.
	void FixedUpdate () {
		// Input lets us use the arrow and WASD keys for movement
		float moveHorizontal = Input.GetAxis ("Horizontal");

		// Need 3 element vector since the object position has 3 parameters (x,y,z)
		Vector3 move = new Vector3 (moveHorizontal, 0, 0);
		player.MovePosition(player.transform.position + (move * speed))
	}
}
