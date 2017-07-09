using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTargetLocation : MonoBehaviour {

	private Animator m_Animator;
	private TargetColour other_colour;
	private TargetColour my_colour;
	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
		my_colour = GetComponent<TargetColour>();

		if (my_colour.colour == "red")
		{
			m_Animator.SetInteger("color", 1);
		}
		else if (my_colour.colour == "blue")
		{
			m_Animator.SetInteger("color", 2);
		}
		else if (my_colour.colour == "green")
		{
			m_Animator.SetInteger("color", 3);
		}
		else if (my_colour.colour == "yellow")
		{
			m_Animator.SetInteger("color", 4);
		}
	}
	
	// Update is called once per frame
	void Update () {
		var pos = Camera.main.WorldToViewportPoint(this.transform.position);
        pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
 		pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
 		transform.position = Camera.main.ViewportToWorldPoint(pos);
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		other_colour = coll.GetComponent<TargetColour>();
		if (coll.tag == "tag_target_location" && other_colour.colour == my_colour.colour)
		{
			Debug.Log ("ENTER tag_target_location");
			CandleManager.Instance.IncreasePlaced();
			m_Animator.SetBool("lit", true);
		}
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		other_colour = coll.GetComponent<TargetColour>();
		if (coll.tag == "tag_target_location" && other_colour.colour == my_colour.colour)
		{
			Debug.Log ("EXIT tag_target_location");
			CandleManager.Instance.DecreasePlaced();
			m_Animator.SetBool("lit", false);
		}
	}
}
