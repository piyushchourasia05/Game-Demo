using UnityEngine;
using System.Collections;
//we need this for work with UI
using UnityEngine.UI;

public class itemChecker : MonoBehaviour {

	//variables for sound files
	public AudioClip OkSound, BoomSound;
	//variable for score counting
	public int score;
	//variable for reference to Score GameObject
	public GameObject ScoreObject;
	//variable for reference to Text componente on Score GameObject
	Text scoreText;

	//will be executed once
	void Start() {
		//reference scoreText to Text component
		scoreText = ScoreObject.GetComponent < Text >();
	}

	//will be executed if one Collider2D went into Trigger2D
	void OnTriggerEnter2D (Collider2D other) {
		//check if collided gameobject has tag Good
		if (other.gameObject.tag == "Good") {
			//increase score
			score = score + 10;
			//set string text to score value, which was converted from int to string
			scoreText.text = score.ToString();
			//play audio file at position from catched gameobject
			AudioSource.PlayClipAtPoint(OkSound, other.transform.position);
			//delete collided gameobject from the scene
			Destroy (other.gameObject);
		}
		//check if collided gameobject has tag Bad
		if (other.gameObject.tag == "Bad") {
			//decrease score value
			score = score - 10;
			//set string text to score value, which was converted from int to string
			scoreText.text = score.ToString();
			//play audio file at position from catched gameobject
			AudioSource.PlayClipAtPoint(BoomSound, other.transform.position);
			//delete collided gameobject from the scene
			Destroy (other.gameObject);
		}
	}
}