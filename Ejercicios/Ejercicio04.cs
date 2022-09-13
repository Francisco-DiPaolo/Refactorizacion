using System;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{

    public List<string>;
    string enemigo;

    private void Start()
    {
        enemigos = new List<string>() { "Orco", "Araña", "Golem", "Goblin" };
        enemigo = "Araña"
    }

    string EncontrandoEnemigo()
    {
        IEnumerable<string> nuevoenemigo = from variable in enemigos
                                           where variable == enemigo
                                           select variable;

        if (nuevoenemigo.Contains(enemigo)) return "Se encontro araña";
        else return "No se encontró";
    }
}
