using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public GameObject gameManager;

    public int coinScoreValue = 10;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<ScoreManager>().addScore(coinScoreValue);
        Destroy(gameObject);
    }
}
