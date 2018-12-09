using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.Experimental.UIElements.Button;

public class ShopScriptToggle : MonoBehaviour
{
	public Text shopBack;
	public GameObject itemButton;
	public ScriptableObjectShop newShop;
	public ScriptableObjectPauseMenu pauseBool;
	
	public void Clicked(string clicked)
	{
		
		
		if (newShop.shopDisplayed == true)
		{
			newShop.shopDisplayed = false;
			shopBack.text = ("Shop").ToString();
			//itemButton.SetActive(false);
		
		}
		else if(newShop.shopDisplayed == false)
		{
			newShop.shopDisplayed = true;
			shopBack.text = ("Back").ToString();
			//itemButton.SetActive(true);
		}
		
	}

	private void Update()
	{
		
	}
}
