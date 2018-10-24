//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

    public Rigidbody hoehe;
    public Transform rotate;

    // Use this for initialization
    void Start () {
<<<<<<< HEAD
        Debug.Log("Camera-Script: \n Ich funktioniere");
=======
        Debug.Log("Camera:Script \n Ich funktioniere");
>>>>>>> f02b04e259b97befd3003fa8913eddd75c63eaea
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        hoehe.AddForce(0, 5, 0 * Time.deltaTime);
        //if(rotate.rotation.x<=30){
            rotate.Rotate((float)0.2, 0, 0 * Time.deltaTime);
        //}
=======
        hoehe.AddForce(0, 10, 0 * Time.deltaTime);
        //rotate.Rotate(1,0,0 * Time.deltaTime);
>>>>>>> f02b04e259b97befd3003fa8913eddd75c63eaea
	}
}
