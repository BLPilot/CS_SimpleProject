using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
	public Transform player;
	public Text distanceText;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
		distanceText.text = player.position.z.ToString("0");
    }
}
