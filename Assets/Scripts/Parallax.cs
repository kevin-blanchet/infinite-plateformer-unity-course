using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject camera;
    public GameObject gameManager;

    public float parallaxEffectX;
    public float parallaxEffectY;

    private float width;

    private float startPositionX;
    private float startPositionY;

    public float speedFactor;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        startPositionX = transform.position.x;
        startPositionY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float distX;
        if (transform.position.x <= startPositionX - width)
        {
            distX = startPositionX + (speedFactor * Time.deltaTime * gameManager.GetComponent<SpeedManager>().speed * parallaxEffectX);
        }
        else
        {
            distX = transform.position.x + (speedFactor * Time.deltaTime * gameManager.GetComponent<SpeedManager>().speed * parallaxEffectX);
        }
        float distY = camera.transform.position.y * parallaxEffectY;

        transform.position = new Vector3(distX, startPositionY + distY, transform.position.z);
    }
}
