using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    void WaterArt()
    {
        PlayerScript playerScript;

        playerScript = GetComponent<PlayerScript>();

        playerScript.mana += 50;

    }
}