using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [System.NonSerialized] public int score = 0;
    public int levelStep = 100;
    private int currentLevel = 0;
    [System.NonSerialized] public int level = 1;

    public TextMeshProUGUI scoreDisplay;

    public void addScore(int addition, bool addXp = true)
    {
        score += addition;
        if (addXp)
        {
            currentLevel += addition;
            if (currentLevel >= levelStep)
            {
                level++;
                GetComponent<SpeedManager>().incrementSpeed();
                currentLevel -= levelStep;
            }
        }
        scoreDisplay.text = score.ToString();
    }
}
