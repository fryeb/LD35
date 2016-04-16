using UnityEngine;
using System.Collections;

public class Snake : MonoBehaviour
{
    public float health;

    void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
    }
}