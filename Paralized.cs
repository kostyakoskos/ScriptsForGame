using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralized : MonoBehaviour
{
    void CureFriend(GameObject player)
    {
        PlayerScript playerScript;
        PlayerScript friendScript;

        friendScript = player.GetComponent<PlayerScript>();
        playerScript = GetComponent<PlayerScript>();
        playerScript.mana -= 85;

        friendScript.normal = true;
        friendScript.health = 1;
    }
}