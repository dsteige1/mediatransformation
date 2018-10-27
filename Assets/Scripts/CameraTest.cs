//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

    public Rigidbody hoehe;
    public Transform rotate;
    public float Force = 2000f;
    public float negForce = -2000f;

    // Use this for initialization
    void Start () {

        Debug.Log("Camera-Script: \n Ich funktioniere");

        hoehe.AddForce(Force * Time.deltaTime, 0, 0);

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("s"))
        {
            //hoehe.AddForce(0, 200 * Time.deltaTime, 0); 
            Force = 0;
        }
       
	}
}
