using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    public int endurance;
    public int enduranceMin;
    public int restDamage;
    public int life;

    void TakeDamage(int damage)
    {
     
        if (endurance > enduranceMin) damage -= restDamage;

        life -= damage;
        
    }
}
