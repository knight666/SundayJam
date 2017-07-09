using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour {

	private Rigidbody2D m_Rigidbody2D;
	private Animator m_Animator;
	public bool is_mirrored = false;
	private int invert = 1;
	Camera camera;

	public Vector2 input_movement = new Vector2();

	// Use this for initialization
	void Start () {
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		m_Animator = GetComponent<Animator>();
		camera = GetComponent<Camera>();
		if (is_mirrored)
		{
			invert = -1;
		}
	}
	
	// Update is called once per frame
	void Update () {

		input_movement = new Vector2();
		
		if (Input.GetKey (KeyCode.W)) {
			input_movement.y = +5*invert;
			//Debug.Log ("w " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.S)) {
			input_movement.y = -5*invert;
			//Debug.Log ("s " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.D)) {
			input_movement.x = +5*invert;
			//Debug.Log ("d " + input_movement.ToString());
		}
		if (Input.GetKey (KeyCode.A)) {
			input_movement.x = -5*invert;
			//Debug.Log ("a " + input_movement.ToString());
		}

		m_Rigidbody2D.velocity = input_movement;

		var pos = Camera.main.WorldToViewportPoint(this.transform.position);
        pos.x = Mathf.Clamp(pos.x, 0f, 1f);
 		pos.y = Mathf.Clamp(pos.y, 0f, 1f);
 		transform.position = Camera.main.ViewportToWorldPoint(pos);


		 

	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log ("cpllision ");
	}
}
