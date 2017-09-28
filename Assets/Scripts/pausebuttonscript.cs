using UnityEngine;
using System.Collections;

public class pausebuttonscript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void PauseButtonFunction()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
		}
		else if (Time.timeScale == 0)
		{
			Time.timeScale = 1;
		}
	}
}