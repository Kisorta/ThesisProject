using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2ender : MonoBehaviour
{

    public GameObject fakeCanvas;
    public GameObject realCanvas;
    public float lengthOfClip;
    public float waitToDelete;


    void Start()
    {
       StartCoroutine(WaitToStartBattle()); 
    }

  
  IEnumerator WaitToStartBattle()
  {
    yield return new WaitForSeconds(lengthOfClip);
    realCanvas.SetActive(true);
    yield return new WaitForSeconds(waitToDelete);
    fakeCanvas.SetActive(false);
  }
}
