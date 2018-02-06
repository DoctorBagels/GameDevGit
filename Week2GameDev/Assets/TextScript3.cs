using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerBehavior.instance.h3)
        {
            transform.position = new Vector3(transform.position.x, 4, transform.position.z);
        }
		
	}
}
