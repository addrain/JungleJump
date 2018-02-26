using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void doQuit(){
		Debug.Log ("has quit game");
		Application.Quit ();
	}
	public void goToCredits(){
		SceneManager.LoadScene("Credits",LoadSceneMode.Single);
	}
	public void goToGame(){
		SceneManager.LoadScene("Jungle",LoadSceneMode.Single);
	}
}
