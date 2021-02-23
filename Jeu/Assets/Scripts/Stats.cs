using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public float health;
    public float currentHealth;
    void Start()
    {
        currentHealth = health;
    }
    public void getHit(float damage)
    {
        currentHealth -= damage;
    }
}
