using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject person;
    private PlayerController playerControllerScript;
    private GameOver gameOverScript;
    private AudioSource foodAudio;
    public AudioClip wrongFood;
    public AudioClip rightFood;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        gameOverScript = GameObject.Find("Main Camera").GetComponent<GameOver>();
        foodAudio = GetComponent<AudioSource>();
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
                if (person.tag != other.tag)
                {
                    playerControllerScript.points -= 5;
                    foodAudio.PlayOneShot(wrongFood, 1.0f);
                }
                else if (person.tag == other.tag)
                {
                    foodAudio.PlayOneShot(rightFood, 1.0f);
                    Destroy(other.gameObject);
                    playerControllerScript.points += 25;
                }
                Destroy(gameObject);
            }
        }
    }
}
