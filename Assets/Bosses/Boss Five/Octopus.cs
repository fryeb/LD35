using UnityEngine;
using System.Collections;

public class Octopus : Boss
{
    public int numBarrels;
    private int currentBarrel;

    void Update()
    {
        if (timer <= 0)
        {

            Transform bullet = Instantiate(bulletPrefab, transform.position, Quaternion.AngleAxis(90, Vector3.left)) as Transform;
            Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            timer = 1 / fireSpeed;
        }
        else timer -= Time.deltaTime;
    }

}