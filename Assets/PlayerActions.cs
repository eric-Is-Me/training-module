using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class PlayerActions : MonoBehaviour {

	public Rigidbody2D player;
	public Canvas canvas;
	private Slider healthBar;
	private Text pointsText;
	private Text healthText;
	public float speed;
	private int curHealth;
	public int maxHealth;
	private int points = 0;

	void Start() {
		/* These components are all children of the Canvas object.
		   The code in this section allows us to work with these 
		   components and their values within the player object.  */
		healthBar = canvas.GetComponentInChildren<Slider> ();
		healthText = canvas.GetComponentsInChildren<Text> () [0];
		pointsText = canvas.GetComponentsInChildren<Text> () [1];

		curHealth = maxHealth;
		healthBar.maxValue = maxHealth;
		healthBar.value = maxHealth;
		healthText.text = curHealth + "/" + maxHealth;
	}

	// FixedUpdate to call updates at fixed rate independent from frame rate.
	void FixedUpdate () {
		// Input lets us use the arrow and WASD keys for movement
		float moveHorizontal = Input.GetAxis ("Horizontal");

		// Need 3 element vector since the object position has 3 parameters (x,y,z)
		Vector3 move = new Vector3 (moveHorizontal, 0, 0);
		player.MovePosition (player.transform.position + (move * speed));
	}

	// Trigger event handlers for collision triggers
	void OnTriggerEnter2D (Collider2D col){
		if (col.name == "GoodObject") {
			points += 1;
			pointsText.text = "Points: " + points;
		}
		if (col.name == "BadObject"){
			curHealth -= 1;
			healthBar.value -= 1;
			healthText.text = curHealth + "/" + maxHealth;
		}
	}
}
