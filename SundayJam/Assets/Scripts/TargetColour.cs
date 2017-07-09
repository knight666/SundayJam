using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetColour : MonoBehaviour {

	public string colour = "white";
	public bool apply_to_renderer = false;

	// Use this for initialization
	void Start () {
		if (apply_to_renderer)
		{
			var renderer = GetComponent<SpriteRenderer>();

			if (colour == "red")
			{
				renderer.color = Color.red;
			}
			else if (colour == "blue")
			{
				renderer.color = Color.blue;
			}
			else if (colour == "green")
			{
				renderer.color = Color.green;
			}
			else if (colour == "yellow")
			{
				renderer.color = Color.yellow;
			}
			else
			{
				renderer.color = Color.white;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
