using System;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    string FindEnemy(string[] enemys)
    {
        for (int i = 0; i < enemys.Length; i++)

            Debug.Log(enemys[i]);

            if (enemys[i].Equals("Araña"))
            {
                return "Araña";
            }
            if (enemys[i].Equals("Lobo"))
            {
                return "Lobo";
            }
            if (enemys[i].Equals("Orco"))
            {
                return "Orco";
            }
        }
        return String.Empty;
    }
}
