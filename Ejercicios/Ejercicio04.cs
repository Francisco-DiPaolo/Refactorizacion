using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{

    public List<string> enemigos;
    string enemigo;

    private void Start()
    {
        enemigos = new List<string>() { "Orco", "Ara�a", "Golem", "Goblin" };
        enemigo = "Ara�a"
    }

    string EncontrandoEnemigo()
    {

        if (nuevoenemigo.Contains(enemigo)) return "Se encontro ara�a";
        else return "No se encontr�";
    }
}
