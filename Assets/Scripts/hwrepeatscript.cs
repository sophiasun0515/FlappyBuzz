using UnityEngine;
using System.Collections;

public class hwrepeatscript : MonoBehaviour {

	public GameObject pipes;

	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}

	void CreateObstacle()
	{
		Instantiate(pipes);
	}
}
