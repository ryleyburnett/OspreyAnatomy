using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScriptStore : MonoBehaviour
{
	public ScriptableObjectShop shopValues;
	public ScriptableObjectCoin coinValues;
	public int coinsYouOwn;
	public int priceOfItem;
	
	public void Clicked(string clicked)

	{
		coinsYouOwn = coinValues.coinCount;
		priceOfItem = shopValues.item1Price;
		
		if (coinValues.coinCount >= shopValues.item1Price)
		{
			coinValues.coinCount = coinsYouOwn - priceOfItem;
			Instantiate(shopValues.item1);

		}
		else if(coinValues.coinCount <= shopValues.item1Price)
		{
			print("Not Enough Money");
		}
		
	}



}
