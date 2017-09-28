using UnityEngine;
using System.Collections;

public class bird : MonoBehaviour {

	public Rigidbody2D rigid;
	public float spd = 5f;
	public UiScript ui;

	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if(Input.GetButtonDown("Fire1")) {

			rigid.velocity = new Vector2(0,spd);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Destroy (gameObject);
			ui.gameOverActivated();
		}

	}

void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "obstac") {
			Destroy (gameObject);
			ui.gameOverActivated();

		}
	}
}
