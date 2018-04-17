using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computerplayer : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float offset;

	void Start () {

		rb2d = this.GetComponent<Rigidbody2D> ();

		float x = Camera.main.ViewportToWorldPoint (Vector3.one).x;
		Vector3 pos = transform.position;
		pos.x = x + offset;
		transform.position = pos;

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {

			rb2d.velocity = new Vector2 (0f, 5f);

		} else if (Input.GetKey (KeyCode.S)) {

			rb2d.velocity = new Vector2 (0f, -5f);

		} else {

			rb2d.velocity = new Vector2(0f, 0f);
		}
	}
}

