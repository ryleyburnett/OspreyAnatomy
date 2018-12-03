using UnityEngine;
using System.Collections;
 
 
public class RelativeLocation : MonoBehaviour
{
	private Vector3 startPos;
	public Vector3 changePos;
	public Vector3 newPosDiff;
	public GameObject Handle;
	public Vector3 gameObjStartPos;
	
	//public float xPos;
	//public float yPos;
	//public float zPos;

	void Start()
	{
		startPos = transform.localPosition;
		
	}
	
	void LateUpdate()
	{
		changePos = transform.localPosition;

		newPosDiff.x = changePos.x - startPos.x;
		newPosDiff.y = changePos.y - startPos.y;
		newPosDiff.z = startPos.z;

		gameObjStartPos.x = Handle.transform.localPosition.x + (newPosDiff.x) / 36;
		gameObjStartPos.y = Handle.transform.localPosition.y + (newPosDiff.y) / 36;
		gameObjStartPos.z = Handle.transform.localPosition.z;

		Handle.transform.localPosition = gameObjStartPos;

	}

	void Update()
	{
		if (Input.GetKey("space"))
		{
			transform.localPosition = startPos;
		}
			
	}

	
}