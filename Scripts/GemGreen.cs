using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGreen : MonoBehaviour
{
    // Giving the green gem 100 points.
    public GameObject Score;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 100;
        collectSound.Play();
        Destroy(gameObject);
    }
}
