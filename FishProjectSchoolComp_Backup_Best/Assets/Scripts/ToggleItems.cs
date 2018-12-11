using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.Experimental.UIElements.Button;

public class ToggleItems : MonoBehaviour
{
	public GameObject itemButton;
	public ScriptableObjectShop newShop;
	public Text controlsDisplay;
	

	private void Update()
	{
		if (newShop.shopDisplayed == true)
		{
			itemButton.SetActive(true);
			controlsDisplay.enabled = false;
		
		}
		else if(newShop.shopDisplayed == false)
		{
			itemButton.SetActive(false);
			
		}
	}
}
