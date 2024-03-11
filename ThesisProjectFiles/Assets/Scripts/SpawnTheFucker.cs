using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTheFucker : MonoBehaviour
{

    public GameObject theFucker;


    private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) 
            {
                StartCoroutine(WaitForFucker());

            }
        }

      IEnumerator WaitForFucker()
      {
        yield return new WaitForSeconds(3f);
        theFucker.SetActive(true);

      }

}
