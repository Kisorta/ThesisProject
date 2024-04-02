using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public AudioClip characterTextSound;
    public AudioSource audioSource;

    // Reference to the next dialogue GameObject
    public GameObject nextDialogue;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        audioSource = GetComponent<AudioSource>();
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void StartDialogue()
    {
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        int index = 0; // Initialize index for this coroutine instance
        while (index < lines.Length)
        {
            textComponent.text = string.Empty;
            foreach (char c in lines[index].ToCharArray())
            {
                textComponent.text += c;
                audioSource.PlayOneShot(characterTextSound);
                yield return new WaitForSeconds(textSpeed);
            }
            index++; // Move to the next line
            yield return new WaitUntil(() => Keyboard.current.spaceKey.wasPressedThisFrame);
        }

        // If all lines are played, deactivate the dialogue manager
        gameObject.SetActive(false);

        // Check if nextDialogue is not null before enabling it
        if (nextDialogue != null)
        {
            nextDialogue.gameObject.SetActive(true);
        }
    }
}
