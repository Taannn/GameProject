using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public HealthBar bar;
    void Start()
    {
        currentHealth = maxHealth;
        bar.SetMaxHealt(maxHealth);
    }
    public void getHit(int damage)
    {
        currentHealth -= damage;
        bar.SetHealth(currentHealth);
    }
}
