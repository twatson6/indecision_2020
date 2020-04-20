//written by Terry 04/19/2020 to keep Score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreKeeper : MonoBehaviour
{
	static public int score = 0;
	public TextMeshProUGUI scoreComponent;
    // Update is called once per frame
    void Update()
    {
        scoreComponent.text = "SCORE: " + score.ToString();
    }
}
