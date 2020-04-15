using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieKill : MonoBehaviour
{
    public GameObject Zombie;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(Zombie);
    }
}
