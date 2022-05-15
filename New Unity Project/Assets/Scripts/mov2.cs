using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov2 : MonoBehaviour
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



		if (Input.GetKey(KeyCode.LeftArrow) )
		{
			x = transform.position.y;
			move = new Vector2(x * speed, rb.velocity.y);

			rb.velocity = move;
		}
		if ( Input.GetKey(KeyCode.RightArrow))
		{
			x = transform.position.y;
			move = new Vector2(-x * speed, rb.velocity.y);

			rb.velocity = move;
		}
		if ( Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Rotate(0, 180, 0);

		}
		if ( Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Rotate(0, 0, 0);
		}
		if (rb.velocity != Vector2.zero)
		{
			anim.SetBool("W", true);
		}
		else if (rb.velocity == Vector2.zero)
		{
			anim.SetBool("W", false);
		}
	}
}
