using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ToggleHUD : MonoBehaviour
{
	public SpriteRenderer childRenderers1;
	public SpriteRenderer childRenderers2;
	public SpriteRenderer childRenderers3;
	public SpriteRenderer childRenderers4;
	public SpriteRenderer childRenderers5;
	public SpriteRenderer childRenderers6;
	public Text childRenderers7;
	public Text childRenderers8;
	public ScriptableObjectPauseMenu disableRenderers;
	
	void Start ()
	{
		GetComponentInChildren<SpriteRenderer>(childRenderers1);
		GetComponentInChildren<SpriteRenderer>(childRenderers2);
		GetComponentInChildren<SpriteRenderer>(childRenderers3);
		GetComponentInChildren<SpriteRenderer>(childRenderers4);
		GetComponentInChildren<SpriteRenderer>(childRenderers5);
		GetComponentInChildren<SpriteRenderer>(childRenderers6);
		GetComponentInChildren<Text>(childRenderers7);
		GetComponentInChildren<Text>(childRenderers8);
		
	}
	

	void Update () 
	{
		if (disableRenderers.paused == true)
		{
			childRenderers1.enabled = false;
			childRenderers2.enabled = false;
			childRenderers3.enabled = false;
			childRenderers4.enabled = false;
			childRenderers5.enabled = false;
			childRenderers6.enabled = false;
			childRenderers7.enabled = false;
			childRenderers8.enabled = false;
		}
		else if(disableRenderers.paused == false)
		{
			childRenderers1.enabled = true;
			childRenderers2.enabled = true;
			childRenderers3.enabled = true;
			childRenderers4.enabled = true;
			childRenderers5.enabled = true;
			childRenderers6.enabled = true;
			childRenderers7.enabled = true;
			childRenderers8.enabled = true;
		}
	}
}
