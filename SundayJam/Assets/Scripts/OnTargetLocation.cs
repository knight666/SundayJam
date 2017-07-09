using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTargetLocation : MonoBehaviour {

	private Animator m_Animator;

	// Use this for initialization
	void Start () {
		m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "tag_target_location")
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
