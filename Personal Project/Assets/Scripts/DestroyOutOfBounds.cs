using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float backBound = -27;
    public float frontBound = 18;
    private PlayerController playerControllerScript;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameOverScript = GameObject.Find("Main Camera").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOverScript.gameOver)
        {
            if (transform.position.z < backBound)
            {
                Destroy(gameObject);
                if (!gameObject.CompareTag("Dust"))
                {
                    playerControllerScript.points -= 100;
                }

                if (playerControllerScript.points < 1)
                {
                    Debug.Log("Game Over");
                }
            }

            if (transform.position.z > frontBound)
            {
                Destroy(gameObject);
            }
        }

        if (gameOverScript.gameOver)
        {
            Destroy(gameObject);
        }
    }
}
