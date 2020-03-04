using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogLegs : MonoBehaviour
{

    void FrogLegsFunc(GameObject gameObject)
    {
        PlayerScript playerScript;

        playerScript = gameObject.GetComponent<PlayerScript>();

        playerScript.weakened = true;

    }

}