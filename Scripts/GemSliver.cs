using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemSliver : MonoBehaviour
{
    // Giving the sliver gem 500 points.
    public GameObject Score;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 500;
        collectSound.Play();
        Destroy(gameObject);
    }
}
