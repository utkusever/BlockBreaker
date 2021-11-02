using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderr : MonoBehaviour
{
    GameSession gamestatus;
    public void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);

    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        gamestatus = FindObjectOfType<GameSession>();
        gamestatus.ResetGame();
        //FindObjectOfType<GameStatus>().ResetGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
