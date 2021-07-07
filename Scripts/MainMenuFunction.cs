using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    // Creating a main menu fuction.
    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        Cursor.visible = true;
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "Best Score: " + bestScore;
    }

    // Takes you to play the game
    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 1;
        SceneManager.LoadScene(2);
    }

    // Resetting the score.
    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
    }

    // Quitting the Game.
    public void QuitGame()
    {
        Application.Quit();
    }
}
