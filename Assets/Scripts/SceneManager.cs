using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void toMainMenu()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void toGameScene()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void toCreditScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CreditScene");
    }
    public void toHelpScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HelpScene");
    }
    public void quitGame()
    {
        Debug.Log("click quit");
        Application.Quit();
    }
}
