using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Ball : MonoBehaviour {

	private Rigidbody2D rb2d;

	//declaring the score variables

	public int Player_1_Score;

	public int Player_2_Score;

	//the text which will appear on screen

	public Text Score_Player_1;

	public Text Score_Player_2;

	//calling the Player 1 Wins text (text value wont allow set.active so use GameObject)
	public GameObject P1_Win;
	public GameObject P2_Win;


	// Use this for initialization
	void Start () {

		rb2d = GetComponent<Rigidbody2D> ();

		rb2d.velocity = new Vector2 (5f, 5f);

		//setting the values to 0 when the game starts

		Player_1_Score = 0;

		Player_2_Score = 0;

		//turning the Player 1 Wins text off by default

		P1_Win.SetActive (false);
		P2_Win.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.position.x >= 17f) {

			this.transform.position = new Vector3 (0f, 0f, 0f);

			//for score 2 script - remove if using the other one

			//Score2.instance.playertwoscored ();

		}

		if (this.transform.position.x <= -17f) {

			this.transform.position = new Vector3 (0f, 0f, 0f);

		}
		//displaying the text value on the text objects done in the unity manager

		Score_Player_1.text = Player_1_Score.ToString();

		Score_Player_2.text = Player_2_Score.ToString();

		//Turning the Player 1 Wins text on when the score is at a particular number

		if (Player_1_Score >= 10) {

			P1_Win.SetActive (true);

			Time.timeScale = 0;

			if (Input.GetKey (KeyCode.Space)) {

				Time.timeScale = 1;

				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex -1); //go back one scene
			}

		}


		if (Player_2_Score >= 10) {

			P2_Win.SetActive (true);

			Time.timeScale = 0;

			if (Input.GetKey (KeyCode.Space)) {

				Time.timeScale = 1;

				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex -1); //go back one scene
			}

		}
	}

	void OnTriggerEnter2D (Collider2D wall) {

		//giving the commands to increment by 1

		if (wall.tag == "wallright") {

			Player_1_Score ++;

			Debug.Log (Player_1_Score);

		}

		//giving the command to increment by 1

		if (wall.tag == "wallleft") {
			
			Player_2_Score ++;

			Debug.Log (Player_2_Score);

		}
	}
}
