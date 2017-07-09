using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	
public class LevelManger : MonoBehaviour {
	public int total_candles;
	public int next_level;
	private bool is_loading = false;
	public GameObject summonedShadowPrefab;
	public GameObject summonedDudePrefab;
	private bool is_summoned = false;

	// Use this for initialization
	void Start () {
		CandleManager.Instance.Reset();
		
	}
	
	// Update is called once per frame
	void Update () {
		if( CandleManager.Instance.candles_placed == 1 && !is_summoned)
		{
			Quaternion rotation = Quaternion.Euler(0, 90.0f, 0.0f);

			GameObject.Instantiate(summonedShadowPrefab,new Vector3(0, 0, 0) ,Quaternion.identity);
			is_summoned = true;
		}
		if( CandleManager.Instance.candles_placed == total_candles && !is_loading )
		{
			GameObject.Instantiate(summonedDudePrefab,new Vector3(0, 0, 0) ,Quaternion.identity);
			StartCoroutine(LoadNextLevel());
			is_loading = true;				
		}
	}

	IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel(next_level);
		
    }
}
