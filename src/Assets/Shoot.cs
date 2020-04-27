// made by Terry for shooting 2/29/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public Transform firePoint;
	
	public GameObject bulletPrefab;
	
	static public float fireRate = 1f;
	
	public float canFire = 1f;
	public float bulletForce = 45f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")&&Time.time > canFire)
		{
			Fire();
			canFire = Time.time + fireRate;
		}
    }
	
	void Fire()
	{
		FindObjectOfType<AudioManager>().Play("GlockShot");
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Rigidbody2D bulletBody = bullet.GetComponent<Rigidbody2D>();
		bulletBody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
	}
}
