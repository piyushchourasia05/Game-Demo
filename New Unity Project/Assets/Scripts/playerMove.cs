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
		
		rb.velocity = move;
		if (rb.velocity != Vector2.zero)
		{
			anim.SetBool("Walk", true);
		}
        else if(rb.velocity == Vector2.zero)
        {
			anim.SetBool("Walk", false);
		}
	}
} 