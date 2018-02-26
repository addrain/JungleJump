﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float scrollSpeed;
	private bool spacePressed = false;

	// Use this for initialization
	void Start () {
//		rb2d = GetComponent<Rigidbody2D> ();
//		rb2d.velocity = new Vector2(scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(!spacePressed && Input.GetKeyDown (KeyCode.Space)){
			spacePressed = true;
			rb2d = GetComponent<Rigidbody2D> ();
			rb2d.velocity = new Vector2(scrollSpeed, 0);
		}
	}
}
