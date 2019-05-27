using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyDrop : MonoBehaviour {

	public Rigidbody2D fallingObj;
	public float speed;
	public int spawnTime;
	public int startWait;
	public int dropCount;
	public string rename;

	void Start () {
		StartCoroutine (spawn());
		// The line below is used to get rid of the pesky naming convention Unity has
		// when instantiating new objects. It's kind of hacky.
		transform.name = transform.name.Replace ("(Clone)", "").Trim ();
	}

	IEnumerator spawn () {
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < dropCount; i++) {
				Vector3 spawnPosition = new Vector3 (Random.Range (-9f, 9f), 5.8f, 0f);
				Instantiate (fallingObj, spawnPosition, Quaternion.identity);
				yield return new WaitForSeconds (spawnTime);
			}
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 move = new Vector3 (0, speed, 0);
		fallingObj.MovePosition (fallingObj.transform.position - move);
	}
}
