using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 1.0f;
    public bool shooting = false;

    private Rigidbody2D body;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newVelocity = Vector3.zero;
	    if (Input.GetKey(KeyCode.W))
        {
            newVelocity.y += speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            newVelocity.x -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newVelocity.y -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newVelocity.x += speed;
        }

        body.velocity = newVelocity;

        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
	}
}
