using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public GameObject cutsceneObject;
    public GameObject deleteVideo;
    public float cutsceneLength;
    public DialogueManager dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the entering GameObject is the player
        {
            StartCoroutine(PlayCutscene());
        }
    }

    IEnumerator PlayCutscene()
    {
        // Enable the cutscene object
        if (cutsceneObject != null)
        {
            cutsceneObject.SetActive(true);
        }

        // Wait for the specified cutscene length
        yield return new WaitForSeconds(cutsceneLength);
        
        cutsceneObject.SetActive(false);
        
        if (deleteVideo != null)
        {
        deleteVideo.SetActive(false);
        }

        // Enable the specified dialogue cutscene
        if (dialogue != null)
        {
            dialogue.gameObject.SetActive(true);
        }
    }

    /*
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the exiting GameObject is the player
        {
            // Disable the target GameObject
            targetObject.SetActive(false);
        }
    }
    */
}
