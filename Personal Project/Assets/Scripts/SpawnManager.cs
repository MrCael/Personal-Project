using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] personPrefabs;
    private GameOver gameOverScript;
    public float startDelay = 2;
    public float spawnInterval = 2;
    public float speedUp = 20;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPerson", startDelay, spawnInterval);
        gameOverScript = GameObject.Find("Main Camera").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > speedUp)
        {
            speedUp += 20;
            CancelInvoke();
            spawnInterval -= 0.2f;
            InvokeRepeating("SpawnRandomPerson", spawnInterval, spawnInterval);
        }
    }

    void SpawnRandomPerson()
    {
        if (!gameOverScript.gameOver)
        {
            startPos = new Vector3(Random.Range(-16, 16), 0, 20);
            int peopleIndex = Random.Range(0, personPrefabs.Length);
            Instantiate(personPrefabs[peopleIndex], startPos, personPrefabs[peopleIndex].transform.rotation);
        }
    }
}
