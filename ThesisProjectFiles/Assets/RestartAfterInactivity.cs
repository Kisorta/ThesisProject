using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class RestartAfterInactivity : MonoBehaviour
{
    private float inactivityTimer = 60f;
    private float resetTime = 0f;
    private float enableTime = 30f;

    public GameObject inactivityCountdown;
    public TextMeshProUGUI countdownText;


    void Start()
    {
        inactivityTimer = 60f;
    }

    void Update()
    {
        countdownText.text = "Due to inactivity, the game will reset in: " + Mathf.FloorToInt(inactivityTimer);

        // Check for user input
        if (Keyboard.current.anyKey.isPressed || Mouse.current.delta.magnitude > 0f)
        {
            // If there's any input, reset the inactivity timer
            inactivityTimer = 60f;
        }
        else
        {
            // Increment the inactivity timer if there's no input
            inactivityTimer -= Time.deltaTime;

            // Check if the inactivity timer exceeds the reset time
            if (inactivityTimer <= resetTime)
            {
                // Reset the application
                ResetApplication();
            }

            if (inactivityTimer <= enableTime)
            {
                inactivityCountdown.SetActive(true);
            }
            else if (inactivityTimer > enableTime)
            {
                inactivityCountdown.SetActive(false);
            }
        }



    }

    void ResetApplication()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
