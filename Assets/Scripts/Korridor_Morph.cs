using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korridor_Morph : MonoBehaviour {

   //public float currentY = 90;
   //public float currentX = 0;
    public Transform Flur_Hoehe;
    public enum LookState
    {
        LookUp,
        LookDown,
        neutral,
    };
    LookState lookState = LookState.neutral;
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
        /*
        temp = transform.localScale;

        temp.x += 0.2f * Time.deltaTime;

        transform.localScale = temp;
        */
        if (lookState==LookState.LookUp){
            tempY = Flur_Hoehe.localScale;
            tempY.y += 0.05f;
            Flur_Hoehe.localScale = tempY;
        };

        if (lookState==LookState.LookDown){
            tempY = Flur_Hoehe.localScale;
            tempY.y -= 0.05f;
            Flur_Hoehe.localScale = tempY;
        }
    }

    public void goHigh(){
        lookState = LookState.LookUp;
    }

    public void goLow(){
        lookState = LookState.LookDown;
    }

    public void goNeutral(){
        lookState = LookState.neutral;
    }
}
