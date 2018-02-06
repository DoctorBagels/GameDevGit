using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveupscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerBehavior.instance.h1 == true)
        {
            transform.position =new Vector3(transform.position.x, 4, transform.position.z);
        }
    }
}
