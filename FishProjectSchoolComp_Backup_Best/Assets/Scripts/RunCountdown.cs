using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunCountdown : MonoBehaviour
{

	private Text label;
	public int scoreReadout;
	public ScriptableObjectCoin coinCounter;

	

	IEnumerator Start ()
	{
		
		label = GetComponent<Text>();

		int number = 1;

		while (number > 0)
		{
			yield return new WaitForSeconds(0.025f);
			label.text = number.ToString();
			number++;
			
			
			coinCounter.score = number;
		


		}
	
	
		//label.text = "";
		//yield return new WaitForSeconds(1);
		//label.text = "Go!";
	}

 
 
	void Update()
	{
		
		if(coinCounter.score % 100 == 0)
		{
			coinCounter.coinCount++;
		}
		
	} 
	
	
}
