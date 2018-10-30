//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

    public Rigidbody hoehe;
    public Transform rotate;
    public float Force = 2000f;
    public float negForce = -2000f;
    public float currentY;
    public float currentX;

    // Use this for initialization
    void Start () {
    
        hoehe.AddForce(Force * Time.deltaTime, 0, 0);
        currentX = 0;
        currentY = 90;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
    
        //Rotation nach rechts per Rechtspfeil;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentY = rotate.eulerAngles.y;
            currentY += 2;
            Camera.main.transform.rotation = Quaternion.Euler(currentX, currentY , 0);
        }

        //Rotation nach links per Linkspfeil;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentY = rotate.eulerAngles.y;
            currentY -= 2;
            Camera.main.transform.rotation = Quaternion.Euler(currentX, currentY, 0);
        }

        //Rotation nach Oben per Pfeil;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            currentX = rotate.eulerAngles.x;
            currentX -= 2;
            Camera.main.transform.rotation = Quaternion.Euler(currentX, currentY, 0);
        }

        ////Rotation nach unten per Pfeil;
        if (Input.GetKey(KeyCode.DownArrow))
        {
            currentX = rotate.eulerAngles.x;
            currentX += 2;
            Camera.main.transform.rotation = Quaternion.Euler(currentX, currentY, 0);
        }
    }
}
