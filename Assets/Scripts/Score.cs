using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

	public int score = 0;

	public Text score1;
	public Text highScore1;
	public Text restart1;

	private int highScore = 0;

	private bool check = false;
	private bool spacePressed = false;
	private GameObject player;
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		score1.GetComponent<Text> ();
		player = GameObject.Find ("Player");
		playerController = player.GetComponent<PlayerController> ();
		highScore = PlayerPrefs.GetInt ("HighScore");
		highScore1.text = "High Score: " + highScore;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			spacePressed = true;
		}
		if (check == false && spacePressed == true && !playerController.lost) {
			StartCoroutine (Score_delay ());
			score1.text = "Score: " + score;
			if (score > highScore) {
				highScore = score;
				PlayerPrefs.SetInt ("HighScore", highScore);
				highScore1.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
			}
		}
		if (playerController.lost) {
			restart1.text = "Press Space to Restart";
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene("Jungle");
			}
		}
	}

	IEnumerator Score_delay() {
		check = true;
		score = score + 1;
		yield return new WaitForSeconds (0.3f);
		check = false;
	}
}
