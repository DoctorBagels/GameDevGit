using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public static GameManager instance;
    public bool trigger1 = false;
    public bool trigger2 = false;
    public bool trigger3 = false;
    public bool trigger4 = false;
    public bool finale = false;

	void Start ()
    {
        instance = this;
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        Time.timeScale = 0;
	}
	

	void Update ()
    {
		if (trigger1)
        {
            cam2.gameObject.SetActive(true);
            cam1.gameObject.SetActive(false);
        }

        if(trigger2)
        {
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);
        }

        if(trigger3)
        {
            cam3.gameObject.SetActive(false);
            cam4.gameObject.SetActive(true);
        }

        if(trigger4)
        {
            cam4.gameObject.SetActive(false);
            cam5.gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
	}
}
