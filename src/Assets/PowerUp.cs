//made by Terry for handling the player's collisions with power-ups 04/04/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision){
		
		if(collision.gameObject.tag=="aspowerup")
		{
			Shoot.fireRate = Shoot.fireRate - Shoot.fireRate/50;
		}
		
		if(collision.gameObject.tag=="mspowerup")
		{
			PlayerMove.playerSpeed = PlayerMove.playerSpeed + .35f;
		}
	}
}
