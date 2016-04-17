using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public float speed = 1.0f;
    public float damage = 1.0f;
    public float duration = 1.0f;
    public int bounce = 1;
    public float bounceDuration = 0.1f;
    public string target;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * speed);
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.transform.tag == target) {
            coll.transform.SendMessage("TakeDamage", damage);
            Object.Destroy(gameObject);
        }
        else if (coll.transform.tag == "Environment") {
            if (bounce == 0) Object.Destroy(gameObject);
            else {
                bounce -= 1;
                duration = bounceDuration;
            }
        }
    }

    void Update()
    {
        if (duration <= 0.0f) Object.Destroy(gameObject);
        else duration -= Time.deltaTime;
    }
    
}
