using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2ender : MonoBehaviour
{

    public GameObject fakeCanvas;
    public GameObject realCanvas;


    void Start()
    {
       StartCoroutine(WaitToStartBattle()); 
    }

  
  IEnumerator WaitToStartBattle()
  {
    yield return new WaitForSeconds(13f);
    realCanvas.SetActive(true);
    yield return new WaitForSeconds(3f);
    fakeCanvas.SetActive(false);
  }
}
