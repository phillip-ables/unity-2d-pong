using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

    //script that handles input from two players
    //player 1 => controls guest with W/S ksys
    //player 2 => controls player with arrow keys

    public GameObject player;
    public GameObject guest;
    public int CharVel;
    public int screenJumpCount;
    public object halfHeight;
    public object halfWidth;
    public void screenJump()
    {
        Camera.main.orthographicSize = Random.Range(2, 8);
        Debug.Log("New Camera Orthographics: "+Camera.main.orthographicSize);

        iterateSet();
        screenJumpCount = 0;
        halfHeight = Screen.height / 34.1 / 2;
        halfWidth = Screen.width / 34.1 / 2;
    }
    public void iterateSet()
    {
        var randomIterate = Random.Range(10, 1000000000000);
    }


    // Use this for initialization
    void Start () {
        Debug.Log("Camera Orthographics: "+Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update () {
        //i want this in the start up menu
        var CharVel = 10f;
        var playerVert = player.transform.position.y;
        var playerHor = player.transform.position.x;
        var guestVert = guest.transform.position.y;
        var guestHor = guest.transform.position.x;
        var halfHeight = Screen.height/34.1/ 2;
        var halfWidth = Screen.width / 34.1 / 2;
        var randomIterate = 10;

        Debug.Log("Random Ieterate: "+randomIterate);

        /*
         * counter which increments everytime a button is keyed
         * when randomIterate is equal to screenJumpCount
         * call screenSizeJump to randomly set the width and height
         * sets new increment value
         */
         if(screenJumpCount >= randomIterate)
        {
            screenJump();
        }

        if (Input.GetKey(KeyCode.UpArrow)
            && playerVert < halfHeight)//move the bat up
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.DownArrow)
                 && playerVert > -halfHeight)//move the bat down
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) 
                 && playerHor > 0)//move the bat left
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.RightArrow)
                 && playerHor < halfWidth)//move the bat right
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(CharVel, 0f, 0f);
            screenJumpCount++;
        }
        else
        {
            player.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            Debug.Log("Current ScreenJump Count: "+screenJumpCount);
        }


        //if guest is pressing the w key
        if (Input.GetKey(KeyCode.W)
             && guestVert < halfHeight)//move the bat up
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, CharVel, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.S) 
                 && guestVert > -halfHeight)//move the bat down
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, -CharVel, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.A) 
                 && guestHor > -halfWidth)//move the bat left
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(-CharVel, 0f, 0f);
            screenJumpCount++;
        }
        else if (Input.GetKey(KeyCode.D) 
             && guestHor < 0)// move the bat right
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(CharVel, 0f, 0f);
            screenJumpCount++;
        }
        else
        {
            guest.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            Debug.Log("Current Jump Count: " + screenJumpCount);
        }

    }
}
