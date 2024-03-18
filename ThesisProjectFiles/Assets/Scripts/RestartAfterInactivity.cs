using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using TMPro;

public class ResetAfterInactivity : MonoBehaviour
{
    private float inactivityTimer = 60f;
    public float resetTime = 0f;

    public GameObject inactivityCountdown;
    public TextMeshProUGUI countdownText;


    void Start()
    {
        countdownText.text = "Due to inactivity: The game will reset in: " + inactivityTimer;
    }

    void Update()
    {
        // Check for user input
        if (Keyboard.current.anyKey.isPressed || Mouse.current.delta.magnitude > 0f)
        {
            // If there's any input, reset the inactivity timer
            inactivityTimer = 0f;
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

            if (inactivityTimer <= resetTime)
            {
                inactivityCountdown.SetActive(true);
            }
            else
            {
                inactivityCountdown.SetActive(false);
            }
        }



    }

    void ResetApplication()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
