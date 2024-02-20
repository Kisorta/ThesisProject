using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject targetObject;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the entering GameObject is the player
        {
            targetObject.SetActive(true); // Enable the target GameObject
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the exiting GameObject is the player
        {
            targetObject.SetActive(false); // Disable the target GameObject
        }
    }
    */
}