using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorridorMorph : MonoBehaviour {

    public Transform Korridor;
    public Transform Player;
    public float morph_Speed;
    Vector3 temp;

    public enum growDirect
    {
        Up,
        Down,
        Tighter,
        neutral,
    };

    growDirect growDirection = growDirect.Up;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Player.position.x >= 30)
        {
            switch (growDirection)
            {
                //Korridor wird höher
                case growDirect.Up:         

                    temp = Korridor.localScale;
                    temp.y += morph_Speed;
                    Korridor.localScale = temp;

                    if (Korridor.localScale.y >= 3)
                        growDirection = growDirect.Down;
                    //Debug.Log(growDirection);

                    break;

                //Korridor wird niedriger und breiter
                case growDirect.Down:       

                    temp = Korridor.localScale;
                    temp.y -= morph_Speed;
                    temp.z += morph_Speed;
                    Korridor.localScale = temp;

                    if (Korridor.localScale.y <= 1)
                        growDirection = growDirect.Tighter;
                    //Debug.Log(growDirection);

                    break;

                //Korridor wird wieder schmaler
                case growDirect.Tighter:    

                    temp = Korridor.localScale;
                    temp.z -= morph_Speed;
                    Korridor.localScale = temp;

                    if (Korridor.localScale.z <= 1)
                        growDirection = growDirect.neutral;

                    break;

                case growDirect.neutral:
                    if (Player.position.x >= 99f)
                        growDirection = growDirect.Up;
                    break;

                default:
                    Debug.Log("default");
                    break;
            }
        }
    }
}