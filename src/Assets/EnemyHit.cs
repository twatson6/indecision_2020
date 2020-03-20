using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    void OnTriggerEnter(Collider Player)
	{
		if(Player.gameObject.CompareTag("Player"))
		{
			Debug.Log("Colliding with player!");
			Player.gameObject.SendMessage("DoDamage");
		}
	}
}
