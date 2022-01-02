using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void gameOver()
    {
        Time.timeScale = 0;
        GameObject.Find("ScoreGroup").GetComponent<CanvasGroup>().alpha = 0;
        GameObject.Find("GameOverGroup").GetComponent<CanvasGroup>().alpha = 1;
        GameObject.Find("GameOverGroup").GetComponent<CanvasGroup>().interactable = true;
    }
}
