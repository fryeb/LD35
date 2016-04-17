using UnityEngine;
using System.Collections;

public class Devil : Boss {

    void Update()
    {
        Vector2 direction = Player.player1.transform.position - transform.position;
        float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
        Quaternion newRot = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRot, turnSpeed * Time.deltaTime);

        if (timer <= 0)
        {
            Transform bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as Transform;
            Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            timer = 1 / fireSpeed;
        }
        if (timer > 0) timer -= Time.deltaTime;
    }

}
