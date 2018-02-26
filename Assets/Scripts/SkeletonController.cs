using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {

	Animator anim;
	private bool swingOnce = false;
	private GameObject player;
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		player = GameObject.Find ("Player");
		playerController = player.GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < -(3.84/2)){
			swingOnce = false;
			Reposition ();
		}
		if(transform.position.x < -.2 && !playerController.lost){
			anim.SetInteger("State",1);
		}
		if (playerController.lost)
			anim.SetInteger ("State", 0);
		if(transform.position.x < -.7 && !playerController.lost)
			anim.SetInteger("State",2);

		if (transform.position.x < -1.0 && swingOnce == false && !playerController.lost) {
			SoundManager.PlaySound ("swing");
			swingOnce = true;
		}
	}
	private void Reposition (){
		Vector2 offset = new Vector2 (3.84f/1.5f * 2f, 0);
		transform.position = (Vector2)transform.position + offset;

		anim.SetInteger("State",0);
	}
}
