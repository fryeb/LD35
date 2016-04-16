using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public float bulletPrefab;

    void Update()
    {

    }

    void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }
}