using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemRed : MonoBehaviour
{
    // Giving the red gem 300 points.
    public GameObject Score;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 300;
        collectSound.Play();
        Destroy(gameObject);
    }
}
