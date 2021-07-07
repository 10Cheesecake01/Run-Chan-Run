using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectToLevel : MonoBehaviour
{
    // This is to create a loading scene.
    public static int redirectToLevel;
    public static int nextLevel;
    
    void Update()
    {
        if(redirectToLevel == 1)
        {
            SceneManager.LoadScene(redirectToLevel);
        }   
    }
}
