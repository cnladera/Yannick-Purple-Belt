using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Platform Object")]
    public GameObject platform;

    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    float pos = 0;

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    void Start()
    {
        for(int i = 0; i < 1000; i++)
        {
            SpawnPlatforms();
        }
    }
    void Update()
    {

    }
    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }
}
