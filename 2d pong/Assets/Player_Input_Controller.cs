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
        Camera.main.orthographicSize = Random.Range(2, 10);
        iterateSet();
        screenJumpCount = 0;

    }
    public void iterateSet()
    {
        var randomIterate = Random.Range(100000000, 100000000000000000);
    }


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
        var randomIterate = 10;
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        var halfWidth = screenBounds.x;
        var halfHeight = screenBounds.y;


        /*
         * counter which increments everytime a button is keyed
         * when randomIterate is equal to screenJumpCount
         * call screenSizeJump to randomly set the width and height
         * sets new increment value
         */
        if ((screenJumpCount)/10 >= randomIterate)
        {
            screenJump();
        }
        Debug.Log("Player.x : " + playerHor);
        Debug.Log("Bounds: " + halfWidth);
        if (playerHor > halfWidth)
        {
            var pos = player.transform.position;
            pos.x = screenBounds.x;
            player.transform.position = pos;
            //upper corner
            //player.transform.position.x = screenBounds.x;

            //Unexpected symbol `,', expecting `)'
            //player.transform.position = (halfWidth, player.transform.position.x);

            //No overload for method `Set' takes `2' arguments
            //player.transform.position.Set(halfWidth, playerHor);
            //playerHor = halfWidth;

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
        }

    }
}
