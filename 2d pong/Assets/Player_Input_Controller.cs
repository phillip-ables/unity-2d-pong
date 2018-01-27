using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

    //script that handles input from two players
    //player 1 => controls guest with W/S ksys
    //player 2 => controls player with arrow keys

    public GameObject player;
    public GameObject guest;


	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        //if guest is pressing the w key
        if (Input.GetKey(KeyCode.W))
        {
            //move the bat up
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //move the bat down

        }
        if (Input.GetKey(KeyCode.A))
        {
            //move the bat left

        }
        else if (Input.GetKey(KeyCode.D))
        {
            //move the bat right

        }
        //if guest is pressing the s key
    }
}
