// made by David for shooting 04/09/2020 to handle Damage for the zombie
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZombieDamage : MonoBehaviour
{
	public float zombieHealth = 3;
	public float canDamage = 1f;
    public float grace = .75f;

	public GameObject Zombie;
	public TextMeshProUGUI zombieHealthComponent;
	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "Bullet" && Time.time > canDamage)
		{
			zombieHealth = zombieHealth - 1;
			canDamage = Time.time + grace;
		}
	}

	void Update()
	{
		if (zombieHealth <= 0)
		{
			zombieDie();
		}

        //zombieHealthComponent.text = "HEALTH: " + zombieHealth.ToString();
	}

	void zombieDie()
	{
		Destroy(gameObject);
	}
}
