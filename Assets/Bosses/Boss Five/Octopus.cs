using UnityEngine;
using System.Collections;

public class Octopus : Boss
{
    public int numBarrels;
    private int currentBarrel = 0;
    private bool direction = true;

    void Awake()
    {
        int layer1 = LayerMask.NameToLayer("Enemy");
        int layer2 = LayerMask.NameToLayer("Environment");
        int layer3 = LayerMask.NameToLayer("UI");
        Physics2D.IgnoreLayerCollision(layer1, layer2, true);
        Physics2D.IgnoreLayerCollision(layer1, layer3, true);
    }

    void FixedUpdate()
    {
        if (timer <= 0)
        {
            if (direction)
            {
                if (currentBarrel < numBarrels) currentBarrel++;
                else direction = false;
            }
            else
            {
                if (currentBarrel > 0) currentBarrel--;
                else direction = true;
            }
            Vector3 launchPosition = new Vector3(currentBarrel, 23, 0);
            Transform bullet = Instantiate(bulletPrefab, launchPosition, Quaternion.AngleAxis(180, Vector3.forward)) as Transform;
            Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            timer = 1 / fireSpeed;
        }
        else timer -= Time.deltaTime;
    }

}