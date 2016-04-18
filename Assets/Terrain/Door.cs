using UnityEngine;
//using UnityEngine.SceneManagement;
using System.Collections;

public class Door : MonoBehaviour
{
    public string destination;

    void OnTriggerEnter2D(Collider2D coll)
    {
        //if (coll.transform.tag == "Player") SceneManager.LoadScene(destination);
        if (coll.transform.tag == "Player") Application.LoadLevel(destination);
    }
}
