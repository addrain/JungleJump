using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginningColliderDisable : MonoBehaviour {

	private BoxCollider2D backgroundCollider;
	private float horizontalLength;

	// Use this for initialization
	void Start () {
		backgroundCollider = transform.parent.GetComponent<BoxCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -3.48){
			backgroundCollider.enabled = false;
		}
		if(transform.position.x < -4){
			gameObject.active = false;
		}
	}
}