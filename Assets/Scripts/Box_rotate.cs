using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_rotate : MonoBehaviour {


    public float spin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, spin * Time.deltaTime, 0);
	}

    public void spinChange(){
        spin = -spin;
    }
}
