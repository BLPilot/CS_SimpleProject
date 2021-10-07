using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
	public int points = 0;
	
    //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			points++;

			Destroy(gameObject);
		}
	}
	
	/*
	private void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,100), "Score: " + points);
	}
	*/
}
