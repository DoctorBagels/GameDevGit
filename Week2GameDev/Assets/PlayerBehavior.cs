using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public float vel;
    Rigidbody rb;
    public static string hint;
    public static PlayerBehavior instance;
    public bool h1 = false;
    public bool h2 = false;
    public bool h3 = false;
    public bool h4 = false;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        instance = this;
	}
	
	void Update () 
    {
        Movement();
        if (h4 && Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndGame");
        }
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(-vel,rb.velocity.y,rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(vel, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -vel);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, vel);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "hintbox")
        {
            hint = "Go to the spiky thing in the ocean to find... the truth.";
            Destroy(col.gameObject);
        }

        if (col.gameObject.name == "Weird object 1")
        {
            h1 = true;
        }

        if (col.gameObject.name == "Rock")
        {
            h2 = true;
        }

        if (col.gameObject.name == "Spikestick")
        {
            h3 = true;
        }

        if (col.gameObject.tag == "truth")
        {
            if (h1 && h2 && h3)
            {
                h4 = true;
            }

        }
    }
}
