using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flur_transform : MonoBehaviour {

    public Transform tiefe;
    Vector3 temp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        temp = transform.localScale;

        temp.x += 0.5f * Time.deltaTime;

        transform.localScale = temp;
		
	}
}
