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
    public int CharVel;


	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        //i want this in the start up menu
        var CharVel = 10f;
        var playerVert = player.transform.position.y;
        var playerHor = player.transform.position.x;
        var guestVert = guest.transform.position.y;
        var guestHor = guest.transform.position.x;
        var halfHeight = heightField.GetComponent<Renderer>().bounds.size.y / 2;
        var halfWidth = widthField.GetComponent<Renderer>().bounds.size.x /2;
        Debug.Log(halfWidth);

        if (Input.GetKey(KeyCode.UpArrow)
            && playerVert < halfHeight)
        {
            //move the bat up
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
            Debug.Log(player.transform.position.y);
        }
        else if (Input.GetKey(KeyCode.DownArrow)
                 && playerVert > -halfHeight)
        {
            //move the bat down
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) 
                 && playerHor > 0 )
        {
            //move the bat left
            player.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);

        }
        else if (Input.GetKey(KeyCode.RightArrow)
                 && playerHor < halfWidth)
        {
            //move the bat right
            player.GetComponent<Rigidbody>().velocity = new Vector3(CharVel, 0f, 0f);
        }
        else
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        }


        //if guest is pressing the w key
        if (Input.GetKey(KeyCode.W)
             && guestVert < halfHeight)
        {
            //move the bat up
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.S) 
                 && guestVert > -halfHeight)
        {
            //move the bat down
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
        }
        else if (Input.GetKey(KeyCode.A) 
                 && guestHor > -halfWidth)
        {
            //move the bat left
            guest.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);
        }
        else if (Input.GetKey(KeyCode.D) 
             && guestHor < 0)
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
