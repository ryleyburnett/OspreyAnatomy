using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ParentScript : MonoBehaviour
{
	public GameObject parent;
	public GameObject child;

	void Update ()
	{

		child.transform.position = parent.transform.position;

	}
}
