using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	
	public ScriptableObjectPauseMenu isPaused;

	public void Clicked(string clicked)
	{
		//print("Clicked");
		
		if (isPaused.paused == true)
		{
			//print("Toggled Unpaused");
			isPaused.paused = false;
		}
		else if(isPaused.paused == false)
		{
			//print("Toggled Paused");
			isPaused.paused = true;
		}
	

	}

	

}
