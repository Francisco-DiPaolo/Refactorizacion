using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    [Range(1, 20)]
    public int criticalChance;
    public int maxDie;

    public void CriticalDamage()
    {
        int die = Random.Range(0, criticalChance);

        if (die < maxDie)
        {
            Debug.Log("Normal Hit");
                return
        }
        Debug.Log("Critical Hit");

    }
}
