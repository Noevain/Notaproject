using UnityEngine;
using System.Collections;

public class Mov : MonoBehaviour {
    public float speed = 4f;
    public GameObject stuffthatismoving;
    public float health = 100f;

    private Loadlevel Loadlevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            stuffthatismoving.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            stuffthatismoving.transform.Translate(-Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            stuffthatismoving.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            stuffthatismoving.transform.Translate(-Vector3.back * speed * Time.deltaTime);
        }
        if (health <= 0f);
        {
            //for now only restart the scene,when we will have death animation
            //just lock the axis and call animation here

        }

    }
}
