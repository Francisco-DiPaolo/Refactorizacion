using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    int force;
    int agility;

    void Start()
    {
        force = 100;
        agility = 50;
    }

    private void SpecialAttack()
    { 
        bool boolCalculation = ((force * 2) / 5 > -1 && agility / 2 > 20)

        if (boolCalculation) Debug.Log("Special Attack");
    }
}
