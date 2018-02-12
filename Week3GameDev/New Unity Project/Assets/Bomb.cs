using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {


	void Start ()
    {
		
	}
	

	void Update ()
    { 
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Trigger1")
        {
            GameManager.instance.trigger1 = true;
        }

        if(col.gameObject.name == "Trigger2")
        {
            GameManager.instance.trigger2 = true;
        }

        if(col.gameObject.name == "Trigger3")
        {
            GameManager.instance.trigger3 = true;
        }

        if(col.gameObject.name == "Trigger4")
        {
            GameManager.instance.trigger4 = true;
        }

        if(col.gameObject.name == "Cannonman")
        {
            Destroy(this.gameObject);
            GameManager.instance.finale=true;
        }
    }
}
