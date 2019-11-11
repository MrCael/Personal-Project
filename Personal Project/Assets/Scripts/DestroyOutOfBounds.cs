using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float backBound = -27;
    public float frontBound = 18;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < backBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }

        if (transform.position.z > frontBound)
        {
            Destroy(gameObject);
        }
    }
}
