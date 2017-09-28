using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	private static int score;
	public Text textscore;
	public GameObject Player;

	void Start () {
		score = 0;
		InvokeRepeating ("ScoreUpdate", 1f, 1f);
	}

	void Update () {
		textscore.text = "Score: " + score; 
	}

	void ScoreUpdate()
	{
		if (Player) {
			score += 1;
		}
	}
}