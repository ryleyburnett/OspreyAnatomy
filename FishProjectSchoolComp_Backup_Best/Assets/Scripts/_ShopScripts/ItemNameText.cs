using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemNameText : MonoBehaviour
{
	public ScriptableObjectShop shopText;
	private Text itemLabel;
	private string itemName;

	
	void Update()
	{
		
		itemLabel = GetComponent<Text>();

		itemName = shopText.item1Name.ToString();
		itemLabel.text = itemName;
		
	} 
}
