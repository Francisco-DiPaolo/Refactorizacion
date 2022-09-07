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
        int specialForce = (force * 2) / 5;
        int specialAgility = agility / 2;

        if (specialForce > -1 && (specialAbility > 20)) Debug.Log("Special Attack");
    }
}
