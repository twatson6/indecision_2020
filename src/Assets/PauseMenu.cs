//Written by Terry Watson 3.04.2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
	public static bool isPaused = false;
	
	public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(isPaused)
			{
				resume();
			}
			else
			{
				pause();
			}
			
		}
    }
	
	public void resume ()
	{
		pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		isPaused = false;
	}
	
	void pause ()
	{
		pauseMenu.SetActive(true);
		Time.timeScale = 0f;
		isPaused = true;
	}
	
	public void menu ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
	
	public void quit ()
	{
		Application.Quit();
	}
}
