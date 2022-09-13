using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{

    string acción;

    void Start()
    {
        acción = "Ataque";
    }

    void EjecutarAcción()
    {
        switch (acción)
        {
            case "Cura":
                    Debug.Log("Me curé");
                break;
            case "Ataque":
                    Debug.Log("Hago daño");
                break;
            case "Ataque Especial":
                    Debug.Log("Empiezo a girar como trompo");
                break;

        }
    }
}
