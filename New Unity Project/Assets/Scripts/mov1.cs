using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov1 : MonoBehaviour
{

	public float speed;

	Rigidbody2D rb;

	Animator anim;

	float x;


	Vector2 move;




	void Start()
	{

		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}


	void Update()
	{



		if (Input.GetKey("a"))
		{
			x = transform.position.y;
			move = new Vector2(x * speed, rb.velocity.y);

			rb.velocity = move;
		}
		if (Input.GetKey("d"))
		{
			x = transform.position.y;
			move = new Vector2(-x * speed, rb.velocity.y);

			rb.velocity = move;
		}
		if (Input.GetKeyDown("a") )
		{
			transform.Rotate(0, 180, 0);

		}
		if (Input.GetKeyDown("d") )
		{
			transform.Rotate(0, 0, 0);
		}
		if (rb.velocity != Vector2.zero)
		{
			anim.SetBool("Walk", true);
		}
		else if (rb.velocity == Vector2.zero)
		{
			anim.SetBool("Walk", false);
		}
	}
}
