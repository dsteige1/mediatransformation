using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korridor_Morph : MonoBehaviour {

   //public float currentY = 90;
   //public float currentX = 0;
    public Transform Flur_Hoehe;
    Vector3 tempY;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            tempY = Flur_Hoehe.localScale;
            tempY.y += 0.1f;
            Flur_Hoehe.localScale = tempY;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempY = Flur_Hoehe.localScale;
            tempY.y -= 0.1f;
            Flur_Hoehe.localScale = tempY;
        }
    }
}
