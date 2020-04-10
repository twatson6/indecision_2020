// made by Terry for shooting 3/20/2020 to handle Damage and End for player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Damage : MonoBehaviour
{
    public float health = 3;
	
	public float canDamage = 1f;
	public float grace = .75f;
	
	public GameObject endMenu;
	public TextMeshProUGUI healthComponent;
	void OnCollisionEnter2D(Collision2D collision){
		
		if(collision.gameObject.tag=="enemy" && Time.time > canDamage)
		{
			health = health - 1;
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
