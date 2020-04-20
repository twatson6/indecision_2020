// edited 4/10/2020 by Terry. Commented out health text/damage grace. Added powerup drop.
// made by David for shooting 04/09/2020 to handle Damage for the zombie
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZombieDamage : MonoBehaviour
{
	public Transform powerupPoint;
	public GameObject msPrefab;
	public GameObject asPrefab;
	public float zombieHealth = 3;
	
	public GameObject Zombie;

	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "Bullet")
		{
			zombieHealth = zombieHealth - 1;
		}
	}

	void Update()
	{
		if (zombieHealth <= 0)
		{
			zombieDie();
		}
	}

	void zombieDie()
	{
		powerUpDrop();
		scoreKeeper.score++;
		Destroy(gameObject);
	}
	
	void powerUpDrop()
	{

		int newRand1 = Random.Range(1,5);
		if(newRand1 == 1)
		{
			int newRand2 = Random.Range(1,3);
			if(newRand2 == 1)
			{
				GameObject upgrade1 = Instantiate(msPrefab, powerupPoint.position, powerupPoint.rotation);
			}
			else if(newRand2 == 2)
			{
				GameObject upgrade2 = Instantiate(asPrefab, powerupPoint.position, powerupPoint.rotation);				
			}
		}		
	}
}
