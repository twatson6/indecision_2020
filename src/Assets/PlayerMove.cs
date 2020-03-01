//made by Terry for the Player Movement 02/29/2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
	public float playerSpeed = 3f;
	private float lookAngle;
	
	public Camera camera;
	public Rigidbody2D rigidBody;
	
	private Vector2 mouse;
	private Vector2 lookHere;
	public Vector2 movement;
	
    // Update is called once per frame
    void Update()
    {
        
		mouse = camera.ScreenToWorldPoint(Input.mousePosition);
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");
		
    }
	
	void FixedUpdate()
	{
		rigidBody.MovePosition(rigidBody.position + playerSpeed * movement * Time.fixedDeltaTime);
		
		lookHere = mouse - rigidBody.position;
		lookAngle = Mathf.Atan2(lookHere.y, lookHere.x) * Mathf.Rad2Deg;
		rigidBody.rotation = lookAngle;
	}
}
