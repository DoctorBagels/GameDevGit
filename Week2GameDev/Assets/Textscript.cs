using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textscript : MonoBehaviour
{
    TextMesh txt;

	void Start ()
    {
        txt = GetComponent<TextMesh>();
	}
	
	void Update ()
    {
        txt.text = PlayerBehavior.hint;
	}
}
