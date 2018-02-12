using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {

    ParticleSystem p;
	void Start ()
    {
        p = GetComponent<ParticleSystem>();
        p.Stop();
	}
	
	void Update ()
    {
        if (GameManager.instance.finale == true)
        {
              p.Play();
        }
	}
}
