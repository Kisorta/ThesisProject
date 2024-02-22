using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTheFucker : MonoBehaviour
{

    public GameObject theFucker;


    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) // Check if the entering GameObject is the player
            {
                theFucker.SetActive(true);
            }
        }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
