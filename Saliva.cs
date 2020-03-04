using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saliva : MonoBehaviour
{
    void SalivaFunc(GameObject gameObject)
    {
        PlayerScript playerScript;

        playerScript = gameObject.GetComponent<PlayerScript>();

        playerScript.health -= 80;

    }
}