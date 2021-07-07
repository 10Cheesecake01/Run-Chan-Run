using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    // Creating this script so that when the player falls off the map, the player dies. 
    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject fadeOut;

   void OnTriggerEnter()
   {
       StartCoroutine(YouFellOff());
   }

   // Sequencing it. 
   IEnumerator YouFellOff()
   {
       youFell.SetActive(true);
       LevelAudio.SetActive(false);
       yield return new WaitForSeconds(2);
       fadeOut.SetActive(true);
       yield return new WaitForSeconds(1);
       GlobalScore.currentScore = 0;
       SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
   }
}
