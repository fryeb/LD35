using UnityEngine;
using System.Collections;

public class Slime : Boss {

	void Update()
    {
        float angle = transform.rotation.eulerAngles.z + turnSpeed * Time.deltaTime;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (timer <= 0)
        {
            Transform bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as Transform;
            Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            timer = 1 / fireSpeed;
        }
        if (timer > 0) timer -= Time.deltaTime;
    }

}
