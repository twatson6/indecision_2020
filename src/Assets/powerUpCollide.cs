//Written by Terry Watson 4.04.2020 to handle collisions for powerups

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpCollide : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag=="Player")
		{
			Destroy(gameObject);
		}
	}
}
