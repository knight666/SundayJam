using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTargetLocation : MonoBehaviour {

	private Animator m_Animator;
	private TargetColour o_renderer;
	private TargetColour m_renderer;
	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
		m_renderer = GetComponent<TargetColour>();

		if (m_renderer.colour == "red")
		{
			m_Animator.SetInteger("color", 1);
		}
		else if (m_renderer.colour == "blue")
		{
			m_Animator.SetInteger("color", 2);
		}
		else if (m_renderer.colour == "green")
		{
			m_Animator.SetInteger("color", 3);
		}
		else if (m_renderer.colour == "yellow")
		{
			m_Animator.SetInteger("color", 4);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		o_renderer = coll.GetComponent<TargetColour>();
		if (coll.tag == "tag_target_location" && o_renderer.colour == m_renderer.colour)
		{
			Debug.Log ("ENTER tag_target_location");
			CandleManager.Instance.IncreasePlaced();
			m_Animator.SetBool("lit", true);
		}
	}
	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.tag == "tag_target_location")
		{
			Debug.Log ("EXIT tag_target_location");
			CandleManager.Instance.DecreasePlaced();
			m_Animator.SetBool("lit", false);
		}
	}
}
