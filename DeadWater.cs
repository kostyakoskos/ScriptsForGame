using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWater : MonoBehaviour
{
    void DeadWaterFunc()
    {
        PlayerScript playerScript;

        playerScript = GetComponent<PlayerScript>();

        playerScript.mana += 50;

    }
}