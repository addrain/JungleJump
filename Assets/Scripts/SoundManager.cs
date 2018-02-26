using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static AudioClip runSound, jumpSound, swingSound, startButtonSound, hitSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		runSound = Resources.Load<AudioClip> ("run");
		jumpSound = Resources.Load<AudioClip> ("jump");
		swingSound = Resources.Load<AudioClip> ("swing");
		startButtonSound = Resources.Load<AudioClip> ("startButton");
		hitSound = Resources.Load<AudioClip> ("hit");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip) {
		switch (clip) {
		case "run":
			audioSrc.PlayOneShot (runSound);
			break;
		case "jump":
			audioSrc.PlayOneShot (jumpSound);
			break;
		case "swing":
			audioSrc.PlayOneShot (swingSound);
			break;
		case "startButton":
			audioSrc.PlayOneShot (startButtonSound,0.1f);
			break;
		case "hit":
			audioSrc.PlayOneShot (hitSound);
			break;
		}
	}
}
