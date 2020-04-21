//Written by Terry 04/20/20 to control the volume slider in settings
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{
	public AudioMixer audioMix;
	void Start()
	{
		audioMix.SetFloat("volume", -20f);
	}
	public void SetVolume (float volume)
	{
		audioMix.SetFloat("volume", volume);
	}
}
