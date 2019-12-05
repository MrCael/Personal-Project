using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.points < 1)
        {
            playerControllerScript.points = 0;
            gameOver = true;
        }
    }
}
