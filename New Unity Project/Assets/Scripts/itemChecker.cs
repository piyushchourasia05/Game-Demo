using UnityEngine;
using System.Collections;
//we need this for work with UI
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class itemChecker : MonoBehaviour {

	
	public AudioClip OkSound, BoomSound;

	public int score;
	private int n;
	
	public GameObject ScoreObject;

	Text scoreText;
	public GameObject a;
	public GameObject b;

	void Start() {
		
		scoreText = ScoreObject.GetComponent < Text >();
		Time.timeScale = 1f;
		n = 0;
	}

	
	void OnTriggerEnter2D (Collider2D other) {
		
		if (other.gameObject.tag == "Good") {
			
			score = score + 10;
			
			scoreText.text = score.ToString();
			
			AudioSource.PlayClipAtPoint(OkSound, other.transform.position);
			
			Destroy (other.gameObject);
		}
	
		if (other.gameObject.tag == "Bad") {
			
			score = score - 10;
			
			scoreText.text = score.ToString();
			
			AudioSource.PlayClipAtPoint(BoomSound, other.transform.position);
			
			Destroy (other.gameObject);
			n = n + 1;
		}
		if(n == 3)
        {
			a.SetActive(true);
			b.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}