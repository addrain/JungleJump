using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

	private BoxCollider2D backgroundCollider;
	private float horizontalLength;

	// Use this for initialization
	void Start () {
		backgroundCollider = GetComponent<BoxCollider2D> ();
		horizontalLength = backgroundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -horizontalLength){
			RepositionBackground ();
		}
	}

	private void RepositionBackground(){
		Vector2 backgroundOffset = new Vector2 (horizontalLength * 2f, 0);
		transform.position = (Vector2)transform.position + backgroundOffset;
	}
}
