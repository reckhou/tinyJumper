﻿using UnityEngine;
using System.Collections;

public class groundDetect : MonoBehaviour {
	public CharController character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		character.TouchGround();
	}
}
