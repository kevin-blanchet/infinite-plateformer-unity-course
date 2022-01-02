using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speedFactor;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = gameManager.GetComponent<SpeedManager>().speed;
        transform.Translate(-speedFactor * speed * Time.deltaTime, 0, 0);
    }
}
