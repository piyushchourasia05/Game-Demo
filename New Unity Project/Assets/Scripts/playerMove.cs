using UnityEngine;
using System.Collections;
public class playerMove : MonoBehaviour {

	
	public float speed;

	Rigidbody2D rb;

	Animator anim;

	float x;
	
	
	Vector2 move;




	void Start () {
		
		rb = GetComponent < Rigidbody2D > ();
		anim = GetComponent<Animator>();
	}

	
	void Update () {
		

		x = Input.GetAxis ("Horizontal");
		
		move = new Vector2 (x * speed, rb.velocity.y);
		anim.Play("Walk");
		rb.velocity = move;
		if(Input.GetKeyDown("a")|| Input.GetKeyDown(KeyCode.LeftArrow))
        {
			transform.Rotate(0, 180, 0);
			
        }
		if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Rotate(0, 0, 0);
		}
	
	}
} 