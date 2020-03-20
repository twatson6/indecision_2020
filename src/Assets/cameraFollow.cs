//Made by Terry for camera following on 03/04/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
	public Transform Player;
	public float smoother = 0.8f;
	public Vector3 goal;
	private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if(Player.position != goal)
		{
			goal = Player.position;
			goal.z = transform.position.z;
			transform.position = Vector3.SmoothDamp(transform.position, goal, ref velocity, smoother);
		}
		
    }
}
