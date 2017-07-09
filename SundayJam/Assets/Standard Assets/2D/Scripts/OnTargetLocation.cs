using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTargetLocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{		
		if (coll.tag == "tag_target_location")
		{
			Debug.Log ("ENTER tag_target_location");
		}
	}
	void OnTriggerExit2D(Collider2D coll)
	{		
		if (coll.tag == "tag_target_location")
		{
			Debug.Log ("EXIT tag_target_location");
		}
	}
}
