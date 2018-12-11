using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop")]
public class ScriptableObjectShop : ScriptableObject
{
    public GameObject item1;
    public int item1Price;
    public string item1Name;
    [Space(15)]
    public GameObject item2;
    public int item2Price;
    public string item2Name;
    //Items are processed by shop script.
    [Space(15)] 
    public string textDisplay;
    public bool shopDisplayed;

    
    private void OnEnable()
    {
        shopDisplayed = false;
    }
    
}
