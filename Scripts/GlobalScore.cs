using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    // Creating a score counter.
    public GameObject Score;
    public static int currentScore;
    public int internalScore;

    void Update()
    {
        internalScore = currentScore;
        Score.GetComponent<Text>().text = "" + internalScore;
    }
}
