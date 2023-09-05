using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float spawnInterval = 4.0f;
    private float startDelay = 1.0f;
    
    private float spawnIntervalLowerLimit = 3.0f;
    private float spawnIntervalUpperLimit = 6.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBallsIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallsIndex], spawnPos, ballPrefabs[randomBallsIndex].transform.rotation);

        SetRandomSpawnInterval();
    }

    // Make the spawn interval a random value between 3 seconds and 5 seconds
    void SetRandomSpawnInterval()
    {
        spawnInterval = Random.Range(spawnIntervalLowerLimit, spawnIntervalUpperLimit);
    }
}
