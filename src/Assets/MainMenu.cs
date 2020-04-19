//Written by Terry Watson 2.14.2020
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Increments scene to Game scene TW
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		
	}
	//Sends Application Quit, also prints Pressed Quit for presses in the editor TW
	public void QuitGame()
	{
		Debug.Log("Pressed Quit!");
		Application.Quit();
        FindObjectOfType<AudioManager>().Play("Main_Menu");
	}
}
