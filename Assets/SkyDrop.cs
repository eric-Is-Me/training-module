using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyDrop : MonoBehaviour {

	public Rigidbody2D fallingObj;
	public float speed;
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (0, speed, 0);
		fallingObj.MovePosition (fallingObj.transform.position - move);
	}
}
