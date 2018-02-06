using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubescript : MonoBehaviour {

    Rigidbody rb;
    public int Vel;


	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}
	

	void Update ()
    {
        Movement();
	}

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-Vel, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(Vel, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, Vel);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -Vel);
        }
    }
}
