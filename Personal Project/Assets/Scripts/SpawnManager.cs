using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] personPrefabs;
    public float startDelay = 2;
    public float spawnInterval = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPerson", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomPerson()
    {
        int peopleIndex = Random.Range(0, personPrefabs.Length);
        Instantiate(personPrefabs[peopleIndex], new Vector3(Random.Range(-17, 17), 0, 17), personPrefabs[peopleIndex].transform.rotation);
    }
}
