﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroy : MonoBehaviour {

	void OnTriggerExit2D (Collider2D obj) {
		Destroy (obj.gameObject);
	}
}
