using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgainstPoison : MonoBehaviour
{
    void Poison(GameObject player)
    {
        PlayerScript playerScript;
        PlayerScript friendScript;

        friendScript = player.GetComponent<PlayerScript>();
        playerScript = GetComponent<PlayerScript>();
        playerScript.mana -= 30;

        friendScript.normal = true;
    }
}