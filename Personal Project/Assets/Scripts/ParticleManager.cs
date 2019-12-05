using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    private SpawnManager spawnManagerScript;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        spawnManagerScript = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        gameOverScript = GameObject.Find("GameOverManager").GetComponent<GameOver>();
        InvokeRepeating("SpawnParticles", spawnManagerScript.startDelay, spawnManagerScript.spawnInterval);
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnManagerScript.speedUp)
        {
            CancelInvoke();
            InvokeRepeating("SpawnParticles", spawnManagerScript.spawnInterval, spawnManagerScript.spawnInterval);
        }
    }

    void SpawnParticles()
    {
        if (!gameOverScript.gameOver)
        {
            Instantiate(gameObject, spawnManagerScript.startPos, transform.rotation);
            Debug.Log("test again");
        }
    }
}
