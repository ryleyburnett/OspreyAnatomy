using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextReadout : MonoBehaviour 
{

	private Text label;
	public ScriptableObjectCoin coinCounter;
	private string coins;

	
	void Update()
	{
		
		label = GetComponent<Text>();

		coins = coinCounter.coinCount.ToString();
		label.text = coins;
		
	} 
	
}
