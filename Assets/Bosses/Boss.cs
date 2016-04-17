using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public string target;
    public float turnSpeed;
    public float fireSpeed;

    public Transform bulletPrefab;

    protected Animator anim;
    protected Quaternion aim;
    protected float timer = 0;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
            Destroy(gameObject);
        anim.SetTrigger("Hit");
    }
}