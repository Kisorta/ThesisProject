using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;


public class FighterAction : MonoBehaviour
    {
    [SerializeField]
    private GameObject enemy;
    private GameObject hero;

    [SerializeField]
    private GameObject meleePrefab;
    [SerializeField]
    private GameObject specialPrefab;
    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject specialAttack;

    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        if(tag == "Hero")
        {
            victim = enemy;
        }
        if(btn.CompareTo("melee") == 0)
        {
            Debug.Log("Melee Attack");
        }
        else if (btn.CompareTo("special") == 0)
        {
            Debug.Log("Special Attack");
        }
        else
        {
            Debug.Log("Guard");
        }
    }

}
