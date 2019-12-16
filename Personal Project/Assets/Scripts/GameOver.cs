using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public AudioSource gameAudio;
    public Image gameOverUI;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.points < 1)
        {
            playerControllerScript.points = 0;
            gameOver = true;
            gameAudio.Stop();
            gameOverUI.gameObject.SetActive(true);
        }
    }
}
