using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private Vector3 playerStart;
    private GameObject player;

    // Start is called before the first frame update
    public void LoadLevel()
    {
        playerStart = transform.Find("PlayerStart").position;
        Debug.Log(playerStart);
        player = GameObject.Instantiate(LevelManager.inst.playerPrefab, playerStart, Quaternion.identity);
    }
}