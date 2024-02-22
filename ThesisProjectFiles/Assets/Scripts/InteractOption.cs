using UnityEngine;
using UnityEngine.InputSystem;

public class InteractOption : MonoBehaviour
{
    public GameObject inspectDialogue;
    public GameObject thoughtBubble;

    private bool dialogueActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thoughtBubble.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thoughtBubble.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed, the player is in the trigger area, and dialogue hasn't been activated yet
        if (Keyboard.current.spaceKey.wasPressedThisFrame && thoughtBubble.activeSelf && !dialogueActivated)
        {
            // Activate the inspectDialogue
            inspectDialogue.SetActive(true);

            // Mark dialogue as activated
            dialogueActivated = true;
        }
    }
}
