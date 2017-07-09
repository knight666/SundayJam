using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleManager : Singleton<CandleManager> {
	protected CandleManager () {} // guarantee this will be always a singleton only - can't use the constructor!
 
	public string myGlobalVar = "whatever";
	private int candles_placed = 0;

	public void IncreasePlaced ()
	{
		candles_placed = candles_placed + 1;
		Debug.Log ("candles_placed " + candles_placed.ToString());
	}
	public void DecreasePlaced ()
	{
		candles_placed = candles_placed - 1;
		Debug.Log ("candles_placed " + candles_placed.ToString());
	}
}
