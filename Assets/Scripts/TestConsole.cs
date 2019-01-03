using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConsole : MonoBehaviour {

    private void Start()
    {
        Debug.Log("Start");
    }

    public void ConsoleTest(){
        Debug.Log("Event fired!");
    }
}
