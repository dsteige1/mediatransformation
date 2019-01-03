using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

    public int Speed;
    private int rounds = 0;
    Vector3 pos = new Vector3(0, 2.255f, -0.341f);  //Ursprungsposition

	void Start () 
    {
		
	}

	void Update () 
    {
        if(Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * Speed * Time.deltaTime ;  //Position des Players += Kamerablickrichtung
        }

        if(transform.position.x >=100f)
        {
            if (rounds <= 2)
            {
                transform.position = pos;  //Position des Players wird = pos gesetzt
                rounds++;

                Debug.Log("Rounds: " + rounds);
            }
        }
		
	}
}
