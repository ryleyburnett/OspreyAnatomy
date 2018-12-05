using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PauseState")]
public class ScriptableObjectPauseMenu : ScriptableObject
{
	public bool paused;

	private void OnEnable()
	{
		paused = false;
	}
}
