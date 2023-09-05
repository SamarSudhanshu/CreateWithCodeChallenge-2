using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float intervalDelay = 2.0f;
    private float lastSpawnTime;

    void Start()
    {
        lastSpawnTime = Time.time;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastSpawnTime >= intervalDelay)
        {
            SpawnDog();
            lastSpawnTime = Time.time;
        }
    }

    void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
