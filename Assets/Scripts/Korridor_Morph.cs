using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korridor_Morph : MonoBehaviour {

   //public float currentY = 90;
   //public float currentX = 0;
    public Transform Flur_Hoehe;
    Vector3 tempY, temp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

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

        //Flur wird 0.2 länger
        temp = transform.localScale;

        temp.x += 0.2f * Time.deltaTime;

        transform.localScale = temp;
    }

    public void goHigh(){
        tempY = Flur_Hoehe.localScale;
        tempY.y += 0.2f;
        Flur_Hoehe.localScale = tempY;
    }

    public void goLow(){
        tempY = Flur_Hoehe.localScale;
        tempY.y -= 0.2f;
        Flur_Hoehe.localScale = tempY;
    }
}
