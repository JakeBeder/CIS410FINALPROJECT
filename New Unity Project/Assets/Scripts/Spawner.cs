using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public int count;


    public static event Action EnemySpawned;

    Vector3 height = new Vector3(0.0f, 0.5f, 0.0f);
    public GameObject StartLocation;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        if (GameManager.enemies > 0)
        {
            GameManager.enemies -= 1;
            GameObject clone = (GameObject)Instantiate(spawnee, StartLocation.transform.position + height, StartLocation.transform.rotation);
            EnemySpawned();
        }



    }


}
