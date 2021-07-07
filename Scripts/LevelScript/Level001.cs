using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    // Creating a transition when the player moves from one level to another level.
    void Start()
    {
        RedirectToLevel.redirectToLevel = 2;
        RedirectToLevel.nextLevel = 3;
        StartCoroutine(fadeInOff());
    }

    // Sequencing it.
    IEnumerator fadeInOff()
   {
       yield return new WaitForSeconds(1);
       fadeIn.SetActive(false);
   }

  
}
