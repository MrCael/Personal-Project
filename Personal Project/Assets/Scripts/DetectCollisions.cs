using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject person;
    private PlayerController playerControllerScript;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameOverScript = GameObject.Find("GameOverManager").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameOverScript.gameOver)
        {
            if (other.tag != "Food")
            {
                Destroy(gameObject);
                if (person.tag != other.tag)
                {
                    playerControllerScript.points -= 5;
                }
                if (person.tag == other.tag)
                {
                    Destroy(other.gameObject);
                    playerControllerScript.points += 25;
                }
            }
        }
    }
}
