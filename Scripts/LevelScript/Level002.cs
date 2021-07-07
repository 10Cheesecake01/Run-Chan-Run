using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;

    // Creating a transition when the player moves from one level to another level.
    void Start()
    {
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 4;
        StartCoroutine(fadeInOff());
    }

    // Sequencing it.
    IEnumerator fadeInOff()
   {
       yield return new WaitForSeconds(1);
       fadeIn.SetActive(false);
   }

  
}
