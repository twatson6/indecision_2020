using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            if(Damage.godMode != true)
			{
				Damage.godMode = true;
			}
			else
			{
				Damage.godMode = false;
			}
		}
		
		if (Input.GetKeyDown(KeyCode.KeypadPlus))
		{
			Shoot.fireRate = .1f;
		}
		
		if (Input.GetKeyDown(KeyCode.KeypadDivide))
		{
			PlayerMove.playerSpeed += 5f;
		}
    }
}
