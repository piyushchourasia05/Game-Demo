using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject != null)
		{

			if (other.gameObject.tag == "Good")
			{


				Destroy(other.gameObject);
			}

			if (other.gameObject.tag == "Bad")
			{


				Destroy(other.gameObject);
			}
		}
	}
}
