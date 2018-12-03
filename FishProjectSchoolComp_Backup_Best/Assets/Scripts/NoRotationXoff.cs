using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotationXoff : MonoBehaviour 
{

	public GameObject noZRotObj;

	public float xRot;
	public float yRot;
	public float zRot;


	void Update ()
	{
		xRot = noZRotObj.transform.localEulerAngles.x;
		noZRotObj.transform.localEulerAngles = new Vector3(xRot,yRot,zRot);
		
	}
}
