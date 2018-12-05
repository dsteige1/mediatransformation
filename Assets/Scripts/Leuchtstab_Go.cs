using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leuchtstab_Go : MonoBehaviour {

    public Rigidbody rightStaff, middleStaff, leftStaff;
    public int yVelo1, yVelo2, yVelo3;

    // Use this for initialization
	void Start () {
        //myStaff.AddForce(0, yVelo * Time.deltaTime, 0);
	}
	
	// Update is called once per frame
	void Update () {
        //myStaff.AddForce(0, yVelo * Time.deltaTime, 0);
    }

    public void goUp(){
        rightStaff.AddForce(0, yVelo3 * Time.deltaTime, 0);
    }

    public void goDown(){
        leftStaff.AddForce(0, yVelo1 * Time.deltaTime, 0);
    }
}
