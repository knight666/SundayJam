using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleManager : Singleton<CandleManager> {
	protected CandleManager () {} // guarantee this will be always a singleton only - can't use the constructor!
 
	public string myGlobalVar = "whatever";
	public GameObject summonedDudePrefab;
	private int candles_placed = 0;
	private bool is_summoned = false;
	private int dudes_summoned = 0;

	public void IncreasePlaced ()
	{
		candles_placed = candles_placed + 1;
		Debug.Log ("candles_placed " + candles_placed.ToString());
		/*if(candles_placed > dudes_summoned)
		{
			GameObject.Instantiate(summonedDudePrefab,new Vector3(0, 0, 0) ,Quaternion.identity);
			dudes_summoned =  dudes_summoned +1;
		}*/
		
	}
	public void DecreasePlaced ()
	{
		candles_placed = candles_placed - 1;
		Debug.Log ("candles_placed " + candles_placed.ToString());
	}
	void Update () {
		if( candles_placed == 1 && !is_summoned)
		{
			Quaternion rotation = Quaternion.Euler(0, 90.0f, 0.0f);

			GameObject.Instantiate(summonedDudePrefab,new Vector3(0, 0, 0) ,Quaternion.identity);
			is_summoned = true;
		}
		

	}
}
