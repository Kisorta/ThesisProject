using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameRestart : MonoBehaviour
{
 
    public float countdownTime = 5f; 

    private float timer;

    void Start()
    {
        timer = countdownTime;
    }

    void Update()
    {
        timer -= Time.deltaTime; 

        if (timer <= 0)
        {
            
            SceneManager.LoadScene(0);
        }
    }
 
}
