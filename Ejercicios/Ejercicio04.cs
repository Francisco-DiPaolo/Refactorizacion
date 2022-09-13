using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{

    public List<string> enemigos;
    string enemigo;

    private void Start()
    {
        enemigos = new List<string>() { "Orco", "Araña", "Golem", "Goblin" };
        enemigo = "Araña"
    }

    string EncontrandoEnemigo()
    {

        if (nuevoenemigo.Contains(enemigo)) return "Se encontro araña";
        else return "No se encontró";
    }
}
