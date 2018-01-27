using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

    //script that handles input from two players
    //player 1 => controls guest with W/S ksys
    //player 2 => controls player with arrow keys

    public GameObject player;
    public GameObject guest;
    public GameObject widthField;
    public GameObject heightField;


	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () { 
        var CharVel = 10f;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //move the bat up
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //move the bat down
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //move the bat left
            player.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //move the bat right
            player.GetComponent<Rigidbody>().velocity = new Vector3(CharVel, 0f, 0f);
        }
        else
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        }


        //if guest is pressing the w key
        if (Input.GetKey(KeyCode.W))
        {
            //move the bat up
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //move the bat down
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //move the bat left
            guest.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //move the bat right
            guest.GetComponent<Rigidbody>().velocity = new Vector3(CharVel, 0f, 0f);
        }
        else
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        }

    }
}
