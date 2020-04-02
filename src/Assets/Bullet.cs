//made by Terry for shooting on 02/29/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public GameObject Explosion;

	void OnCollisionEnter2D(Collision2D collision)
	{
		GameObject explode = Instantiate(Explosion, transform.position, Quaternion.identity);
		Destroy(explode, 2f);
        Destroy(gameObject);
	}
}
