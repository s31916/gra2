using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]  public float maxhealth = 100;
    [SerializeField] public float health = 100;
    public void TakeDamage(float damage)
    {
    health = health - damage;
        if ( health < 0 ) { health = 0; } 
        if ( health > maxhealth ) { health = maxhealth; }

    }
}
