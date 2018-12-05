using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggle : MonoBehaviour 
{

    public ScriptableObjectPauseMenu isDisplayed;
   

    private void Update()
    {
        if (isDisplayed.paused == true)
        {
            transform.localPosition = new Vector3(0, 257, 0);
        }
        else if (isDisplayed.paused == false)
        {
            transform.localPosition = new Vector3(0, -700, 0);
        }
    }
}
