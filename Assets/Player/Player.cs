using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 1.0f;
    public bool shooting = false;

    private Rigidbody2D body;
    private Vector2 direction;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        direction = Vector2.zero;
        shooting = false;
        Vector3 newVelocity = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            shooting = true;
            direction.y = 1.0f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            shooting = true;
            direction.y = -1.0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            shooting = true;
            direction.x = -1.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            shooting = true;
            direction.x = 1.0f;
        }

	    if (Input.GetKey(KeyCode.W))
        {
            newVelocity.y += speed;
            if (!shooting) direction.y += 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newVelocity.y -= speed;
            if (!shooting) direction.y -= 1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newVelocity.x -= speed;
            if (!shooting) direction.x -= 1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newVelocity.x += speed;
            if (!shooting) direction.x += 1.0f;
        }

        if (direction == Vector2.zero) direction = Vector2.up;

        body.velocity = newVelocity;

        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
	}
}
