using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float offset;

	// Use this for initialization
	void Awake () {

		rb2d = this.GetComponent<Rigidbody2D> ();
		
	}

	void Start()
	{
		float x = Camera.main.ViewportToWorldPoint (Vector3.zero).x;
		Vector3 pos = transform.position;
		pos.x = x + offset;
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {

			rb2d.velocity = new Vector2 (0f, 5f);

		} else if (Input.GetKey (KeyCode.DownArrow)) {

			rb2d.velocity = new Vector2 (0f, -5f);

		} else {

			rb2d.velocity = new Vector2(0f, 0f);
		}
}
}
