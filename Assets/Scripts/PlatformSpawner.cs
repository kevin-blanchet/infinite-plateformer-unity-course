using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject coinPlatformPrefab;

    public GameObject gameManager;

    public float timerMax = 1;
    private float timer = 0;

    public float rangeY = 1;
    private float posY = -2;
    private float maxPosY = 15;

    private float secondPlatformHeight = 3;

    public int platformScoreValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platformPrefab, new Vector3(0, posY, 0), Quaternion.identity);
        addPlatformAtRangeY(5, false);
        addPlatformAtRangeY(10, false);
        addPlatformAtRangeY(15, false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameManager.GetComponent<StartManager>().start)
        {
            //spawns a platform every timerMax seconds
            timer += Time.deltaTime;
            if (timer >= timerMax)
            {
                addPlatformAtRangeY();
                timer = 0;
            }
        }
    }

    void addPlatformAtRangeY(float x = 15, bool addScore = true)
    {
        posY = Mathf.Clamp(posY += Random.Range(-rangeY, rangeY), -maxPosY, maxPosY);
        Instantiate(newPlatform(), new Vector3(x, posY, 0), Quaternion.identity);
        if (Random.Range(1, 100) <= 20) // Une chance de spawn une seconde plateforme au dessus de la premiere
        {
            Instantiate(newPlatform(), new Vector3(x, posY + secondPlatformHeight, 0), Quaternion.identity);
            posY += secondPlatformHeight / 3; // On ajuste la position de la plateforme suivante
        }
        if (addScore)
            gameManager.GetComponent<ScoreManager>().addScore(platformScoreValue);
    }
    private GameObject newPlatform()
    {
        if (Random.Range(1, 100) <= 20)
        {
            return coinPlatformPrefab;
        }
        else
        {
            return platformPrefab;
        }
    }
}
