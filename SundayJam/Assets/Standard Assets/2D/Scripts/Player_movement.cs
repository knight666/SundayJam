using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {

	private Rigidbody2D m_Rigidbody2D;
	private Animator m_Animator;

	public Vector2 input_movement = new Vector2();

	// Use this for initialization
	void Start () {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		input_movement = new Vector2();
		
		if (Input.GetKey (KeyCode.W)) {
			input_movement.y = +5;
			//Debug.Log ("w " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.S)) {
			input_movement.y = -5;
			//Debug.Log ("s " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.D)) {
			input_movement.x = +5;
			//Debug.Log ("d " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.A)) {
			input_movement.x = -5;
			//Debug.Log ("a " + input_movement.ToString());
		}

		

		 m_Rigidbody2D.velocity = input_movement;

	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log ("cpllision ");
	}
}
