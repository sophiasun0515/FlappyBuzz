using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiScript : MonoBehaviour {

	public Button[] buttons;
	bool gameOver;

	void Start () {

		gameOver = false;

	}

	void Update () {

	}

	public void Exit(){
		Application.Quit ();
	}

	public void Replay(){
		SceneManager.LoadScene("Game");
	}
		

	public void Menu(){

		SceneManager.LoadScene ("Menu");
	}



	public void gameOverActivated(){
		gameOver = true;
		foreach (Button button in buttons) {
			button.gameObject.SetActive(true);
		}
	}
}

