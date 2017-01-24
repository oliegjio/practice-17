using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleShutter
{
    public class FindEnemies : MonoBehaviour
    {
        GameObject[] enemies;

        void SearchForEnemies()
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if(enemies.Length > 0)
            {
                foreach(GameObject enemy in enemies)
                {
                    enemy.SetActive(false);
                }
            }
        }
    }
}
