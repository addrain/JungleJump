using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public bool lost = false;
	public float jumpForce;
	private bool grounded = false;
	private bool spacePressed = false;

	Animator anim;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		movement();
	}

	void OnTriggerEnter2D() {
		anim.SetLayerWeight(1, 0);
		grounded = true;
	}
	void OnTriggerStay2D() {
		anim.SetLayerWeight(1, 0);
		grounded = true;
	}
	void OnTriggerExit2D() {
		anim.SetLayerWeight(1, 1);
		grounded = false;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.CompareTag("Skeleton")){
			SoundManager.PlaySound ("hit");
			lost = true;
			gameObject.active = false;
			Debug.Log("LOSE");
		}
	}

	private void movement(){
		if (((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && grounded) && spacePressed){
			SoundManager.PlaySound ("jump");
			rb2d.AddForce(Vector2.up*jumpForce);
		}
		if(rb2d.velocity.y < 0){
			anim.SetBool("land", true);
		} else {
			anim.SetBool("land", false);
		}
		
		if (Input.GetKeyDown (KeyCode.Space))
		{
			anim.SetInteger("State",1);
			spacePressed = true;
		} 
	}
}
