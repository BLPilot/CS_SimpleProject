using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
   public void Setup()
    {
        LevelConfig.levelIndex = 2;
        SceneManager.LoadScene("GameOver");
    }
}
