using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButtons : MonoBehaviour
{
    [SerializeField]
    private bool physical;

    private GameObject hero;

    void Start()
    {
        string temp = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(temp));
        hero = GameObject.FindGameObjectWithTag("Hero");

    }

    private void AttachCallback(string btn)
    {
        if (btn.CompareTo("AttackBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("melee");
        }
        else if (btn.CompareTo("SpecialBtn") == 0)
        {
            hero.GetComponent<FighterAction>().SelectAttack("special");
        }
        else
        {
            hero.GetComponent<FighterAction>().SelectAttack("guard");
        }
    }

}