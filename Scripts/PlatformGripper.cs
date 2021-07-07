using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    // This particular script is for the moving plateform so that when the player lands on the moving plateform,
    // The player will stay on the plateform without being pushed when the player is idle or moving. 
    void OnTriggerEnter()
    {
        thePlayer.transform.parent = theLedge.transform;
    }

    void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
    }
}
