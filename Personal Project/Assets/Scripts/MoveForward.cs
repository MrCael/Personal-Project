using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 15;
    public float speedUp = 10;
    private GameOver gameOverScript;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScript = GameObject.Find("GameOverManager").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOverScript.gameOver)
        {
            if (Time.time > speedUp)
            {
                speed += 1;
                speedUp += 10;
            }

            if (tag == "Food")
            {
                speed = 30;
            }
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
