using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public Transform Player;
    public float moveSpeed = 5f;
    public float defaultSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;

        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if(Player != null)
		{
			Vector3 direction = Player.position - transform.position;
			setMoveSpeed(direction);
		   
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
			rb.rotation = angle;
			direction.Normalize();
			movement = direction;
		}
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    void setMoveSpeed(Vector3 dir)
    {
        if (System.Math.Abs(dir.y) < 2.5 && System.Math.Abs(dir.x) < 2.5)
        {
            moveSpeed = defaultSpeed * 1.5f;
        }
        else
            moveSpeed = defaultSpeed;
    }

}
