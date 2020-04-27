//edited 04/23/2020 to add random spawning behavior by Terry
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnZombie : MonoBehaviour
{
    public GameObject weakZomb;
	public GameObject normalZomb;
	public GameObject strongZomb;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
	static public int zombieCount = 0;

    // Start is called before the first frame update
    void Start()
    {
		InvokeRepeating("SpawnRandom", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(zombieCount);
	
    }

    public void SpawnRandom()
    {
        if (zombieCount <= 100){
			
		
		int newRand;
		if (spawnTime == 0){
			newRand = Random.Range(1,7);
			if(newRand == 1 || newRand == 3)
			{
				Instantiate(weakZomb, transform.position, transform.rotation);
				zombieCount++;
			}
			if(newRand == 2 || newRand == 5)
			{
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount++;
			}
			if(newRand == 4)
			{
				Instantiate(weakZomb, transform.position, transform.rotation);
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount += 2;
			}
			if(newRand == 6)
			{
				Instantiate(strongZomb, transform.position, transform.rotation);
				zombieCount++;
			}
		}
		if (spawnTime == 120)
		{
			newRand = Random.Range(1,7);
			if(newRand == 1)
			{
				Instantiate(weakZomb, transform.position, transform.rotation);
				zombieCount++;
			}
			if(newRand == 2 || newRand == 5)
			{
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount++;
			}
			if(newRand == 4 || newRand == 3)
			{
				Instantiate(weakZomb, transform.position, transform.rotation);
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount += 2;
			}
			if(newRand == 6)
			{
				Instantiate(strongZomb, transform.position, transform.rotation);
				zombieCount++;
			}
		}
		if (spawnTime == 150)
		{
			newRand = Random.Range(1,8);
			if(newRand == 2 || newRand == 5 || newRand == 1)
			{
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount++;
			}
			if(newRand == 4 || newRand == 3)
			{
				Instantiate(weakZomb, transform.position, transform.rotation);
				Instantiate(normalZomb, transform.position, transform.rotation);
				zombieCount++;
				zombieCount++;
			}
			if(newRand == 6 || newRand == 7)
			{
				Instantiate(strongZomb, transform.position, transform.rotation);
				zombieCount++;
			}			
		}
		}
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
