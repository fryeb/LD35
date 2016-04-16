using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public float speed = 1.0f;
    public float damage = 1.0f;
    public float duration = 1.0f;
    public string target;

    private float timer;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * speed);
        timer = duration;
	}

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.transform.tag == target) { coll.transform.SendMessage("TakeDamage", damage); Object.Destroy(gameObject); }
        else if (coll.transform.tag == "Environment") { Object.Destroy(gameObject); }
    }

    void Update()
    {
        if (timer <= 0.0f) Object.Destroy(gameObject);
        else timer -= Time.deltaTime;
    }
    
}
