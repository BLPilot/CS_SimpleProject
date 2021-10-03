using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager inst;
    void Awake()
    {
        if(inst == null)
            inst = this;
        else
            Debug.LogWarning("MULTIPLE LEVEL MANAGERS FOUND!");
    }

    public List<GameObject> levelPrefabs;
    public GameObject playerPrefab;

    private Level level;

    public void Start()
    {
        level = GameObject.Instantiate(levelPrefabs[LevelConfig.levelIndex]).GetComponent<Level>();
        level.LoadLevel();
    }
}
