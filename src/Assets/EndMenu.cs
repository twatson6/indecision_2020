//Written by Terry Watson 3.20.2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
	public GameObject endMenu;
	
	

	public void menu ()
	{
		endMenu.SetActive(false);
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");
	}
	
	public void quit ()
	{
		Application.Quit();
	}
}