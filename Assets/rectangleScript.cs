using UnityEngine;
using System.Collections;

public class rectangleScript : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit) && hit.collider!=null)
				rigidbody.useGravity = true;
		}
	}
	public void onTouch()
	{
		rigidbody.useGravity = true;
	}
}
