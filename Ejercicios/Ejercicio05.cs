using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{

    string acci�n;

    void Start()
    {
        acci�n = "Ataque";
    }

    void EjecutarAcci�n()
    {
        switch (acci�n)
        {
            case "Cura":
                    Debug.Log("Me cur�");
                break;
            case "Ataque":
                    Debug.Log("Hago da�o");
                break;
            case "Ataque Especial":
                    Debug.Log("Empiezo a girar como trompo");
                break;

        }
    }
}
