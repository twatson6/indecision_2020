//made by Terry for shooting on 02/29/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}
}
