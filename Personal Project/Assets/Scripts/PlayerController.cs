using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    private AudioSource playerAudio;
    public AudioClip shootFood;
    private GameOver gameOverScript;
    public Text pointsText;
    public float speed = 20;
    public float horizontalInput;
    public float sideBound = 17;
    public float nextFoodOne;
    public float nextFoodTwo;
    public float nextFoodThree;
    public float nextFoodFour;
    public float nextFoodFive;
    public float foodCooldown = 1;
    public float points;
   

    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("Main Camera").GetComponent<GameOver>();
        playerAudio = GetComponent<AudioSource>();
        points = 100;
        pointsText.text = "Points: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = "Points: " + points.ToString();

        if (!gameOverScript.gameOver)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

            if (transform.position.x < -sideBound)
            {
                transform.position = new Vector3(-sideBound, transform.position.y, transform.position.z);
            }

            if (transform.position.x > sideBound)
            {
                transform.position = new Vector3(sideBound, transform.position.y, transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1) && Time.time > nextFoodOne)
            {
                int foodIndex = 0;
                Instantiate(foodPrefabs[foodIndex], transform.position, transform.rotation);
                playerAudio.PlayOneShot(shootFood, 3.0f);
                nextFoodOne = Time.time + foodCooldown;

            }

            if (Input.GetKeyDown(KeyCode.Alpha2) && Time.time > nextFoodTwo)
            {
                int foodIndex = 1;
                Instantiate(foodPrefabs[foodIndex], transform.position, transform.rotation);
                playerAudio.PlayOneShot(shootFood, 3.0f);
                nextFoodTwo = Time.time + foodCooldown;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3) && Time.time > nextFoodThree)
            {
                int foodIndex = 2;
                Instantiate(foodPrefabs[foodIndex], transform.position, transform.rotation);
                playerAudio.PlayOneShot(shootFood, 3.0f);
                nextFoodThree = Time.time + foodCooldown;
            }

            if (Input.GetKeyDown(KeyCode.Alpha4) && Time.time > nextFoodFour)
            {
                int foodIndex = 3;
                Instantiate(foodPrefabs[foodIndex], transform.position, transform.rotation);
                playerAudio.PlayOneShot(shootFood, 3.0f);
                nextFoodFour = Time.time + foodCooldown;
            }

            if (Input.GetKeyDown(KeyCode.Alpha5) && Time.time > nextFoodFive)
            {
                int foodIndex = 4;
                Instantiate(foodPrefabs[foodIndex], transform.position, transform.rotation);
                playerAudio.PlayOneShot(shootFood, 3.0f);
                nextFoodFive = Time.time + foodCooldown;
            }
        }
    }
}
