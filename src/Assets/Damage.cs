// made by Terry for shooting 3/20/2020 to handle Damage and End for player
// updated by David to account for other zombie types' damage
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Damage : MonoBehaviour
{
    static public float health = 10;
	
	public float canDamage = 1f;
	public float grace = .75f;
	public float normalZombieDamage = 2f;
	public float strongZombieDamage = 3f;
	public float weakZombieDamage = 1f;


	public GameObject endMenu;
	public TextMeshProUGUI healthComponent;
	void OnCollisionEnter2D(Collision2D collision){
		
		if(collision.gameObject.tag=="normalZombie" && Time.time > canDamage)
		{
			health = health - normalZombieDamage;
			canDamage = Time.time + grace;
		}
		else if (collision.gameObject.tag == "strongZombie" && Time.time > canDamage)
		{
			health = health - strongZombieDamage;
			canDamage = Time.time + grace;
		}
		else if (collision.gameObject.tag == "weakZombie" && Time.time > canDamage)
		{
			health = health - weakZombieDamage;
			canDamage = Time.time + grace;
		}
	}
	
	void Update()
	{
		if(health <= 0)
		{
			die();
		}
		
		healthComponent.text = "HEALTH: " + health.ToString();
	}
	
	void die()
	{
		endMenu.SetActive(true);
		Destroy(gameObject);
	}
}
