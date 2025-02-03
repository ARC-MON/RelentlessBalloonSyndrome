using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon_poper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D something)
    {
        switch (something.gameObject.tag)
        {
            case "B_Baloon":
                Globals.Change_HP(-10);
                Destroy(something.gameObject);
                break;

            default:
                Destroy(something.gameObject);
                break;
        }
    }
}
