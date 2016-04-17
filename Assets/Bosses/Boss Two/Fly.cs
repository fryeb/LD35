using UnityEngine;
using System.Collections;

public class Fly : Boss {
    public Transform[] spawn_points;

    void Update()
    {
        if (timer <= 0)
        {
            foreach (Transform t in spawn_points)
            {
                Transform bullet = Instantiate(bulletPrefab, t.position, t.rotation) as Transform;
                Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                timer = 1 / fireSpeed;
            }
        }
        if (timer > 0) timer -= Time.deltaTime;
    }
}
