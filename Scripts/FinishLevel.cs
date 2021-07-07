using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    // This script describes what happenes when the player completes the level.
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;

    public GameObject timeleft;
    public GameObject theScore;
    public GameObject totalScore;

    public int timeCalc;
    public int scoreCalc;
    public int totalScored;

    public GameObject levelBlocker;
    public GameObject fadeOut;

    // We want to collect the gems and make it count as a score. We want to calculate the time taken to complete the level and off he music.
    // After finishing a level we want to calculate everything : Time taken and Gems collected. 
    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        timeCalc = GlobalTimer.extendScore * 100;
        timeleft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("LevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    // Setting this in sequence.
    IEnumerator CalculateScore() 
    {
        timeleft.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.50f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
