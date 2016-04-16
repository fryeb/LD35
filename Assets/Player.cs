using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float speed = 1.0f;
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
	    if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
	}
}
