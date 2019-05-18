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


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        count += 1;
        if (count < 3)
        {
            spawnee.SetActive(true);
            //Instantiate(spawnee, transform.position, transform.rotation);
            //spawnee.SetActive(true);
            if (stopSpawning)
            {
                CancelInvoke("SpawnObject");
            }
        }

    }
}
