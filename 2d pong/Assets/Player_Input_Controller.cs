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

        //player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //if player is pressing the w key
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //move the bat up
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 1f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //move the bat down
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, -1f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move the bat left
            player.GetComponent<Rigidbody>().velocity = new Vector3(-1f, 0f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move the bat right
            player.GetComponent<Rigidbody>().velocity = new Vector3(1f, 0f, 0f);
        }


        //guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //if guest is pressing the w key
        if (Input.GetKeyDown(KeyCode.W))
        {
            //move the bat up
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, 1f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //move the bat down
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, -1f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //move the bat left
            guest.GetComponent<Rigidbody>().velocity = new Vector3(-1f, 0f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            //move the bat right
            guest.GetComponent<Rigidbody>().velocity = new Vector3(1f, 0f, 0f);
        }
    }
}
