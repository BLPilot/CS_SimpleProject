using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    private int _numCoins = 0;
	private bool _numCoinsLocked = false;

	private void OnGUI()
	{
		GUI.Label(new Rect(10, 25, 100, 100), "Coins: " + _numCoins);
		if(_numCoinsLocked == true)
        {
			_numCoinsLocked = false;
        }
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Coin" && _numCoinsLocked == false)
		{
			_numCoins++;
			_numCoinsLocked = true;
		}
	}
}
