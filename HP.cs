using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

namespace mygame
{
    public class HP //: MonoBehaviour
    {
        public bool FlagAddHp = false;
        private void AddHP(GameObject player)
        {
            PlayerScript playerScript;

            playerScript = player.GetComponent<PlayerScript>();

            playerScript.mana -= 2;

            playerScript.health += 30;
        }
        public void flag()
        {
            AddHP();
            FlagAddHp = true;
        }
    }
}