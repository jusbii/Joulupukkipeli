using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] targetsPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInternal = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTargets", startDelay, spawnInternal);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnTargets()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, targetsPrefabs.Length);
        Instantiate(targetsPrefabs[animalIndex], spawnPos, targetsPrefabs[animalIndex].transform.rotation);
    }
}
