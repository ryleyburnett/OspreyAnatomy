using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScriptStore : MonoBehaviour
{
	public ScriptableObjectShop shopValues;
	public ScriptableObjectCoin coinValues;
	public int coinsYouOwn;
	public int priceOfItem;
	public Text displayText;
	
	public void Clicked(string clicked)

	{
		coinsYouOwn = coinValues.coinCount;
		priceOfItem = shopValues.item1Price;
		
			//displayText = GetComponent<Text>();
		
		if (coinValues.coinCount >= shopValues.item1Price)
		{
			coinValues.coinCount = coinsYouOwn - priceOfItem;
			Instantiate(shopValues.item1);
				displayText.text = "Purchased";

		}
		else if(coinValues.coinCount <= shopValues.item1Price)
		{
			displayText.text = "Not Enough Coins";
		}
		
	}



}
