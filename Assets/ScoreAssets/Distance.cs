using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
	public Transform player;
	

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
		player.position.z.ToString("0");
		
    }
	
	private void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,100), "Distance: " + player.position.z.ToString("0"));
	}
}
