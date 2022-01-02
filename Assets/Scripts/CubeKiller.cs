using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKiller : MonoBehaviour
{
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameOver>().gameOver();
        Time.timeScale = 0;
    }
}
