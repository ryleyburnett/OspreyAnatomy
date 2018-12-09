using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop")]
public class ScriptableObjectShop : ScriptableObject
{
    public GameObject item1;
    public float item1Price;
    public string item1Name;
    [Space(15)]
    public GameObject item2;
    public float item2Price;
    public string item2Name;
    //Items are processed by shop script.
    [Space(15)]
    public bool shopDisplayed;

    
    private void OnEnable()
    {
        shopDisplayed = false;
    }
    
}
