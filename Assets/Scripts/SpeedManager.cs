using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float speed = 0;
    float maxSpeed = 10;
    public float speedIncrement = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void incrementSpeed()
    {
        if (speed < maxSpeed)
        {
            speed += speedIncrement;
        }
    }
}
