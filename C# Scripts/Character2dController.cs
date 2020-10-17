using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

//All made by Zach

public class Character2dController : MonoBehaviour
{

    //sets variables, don't need a start function.
    public float movespeed = 5; //sets movement speed.

    public Rigidbody2D rb; //adds a rigidbody compnent to script

    Vector2 move; //creates a 2d vector which contains X and Y coords of if the player is moving. 

    // Update is called once per frame
    private void Update()
    {
        //input
        move.x = Input.GetAxisRaw("Horizontal"); // sets the x of the 2d vector to either -1, 0, or 1. If the player is holdinf left arrow-
        //it returns a -1, signifying left. if nothing at all, 0. if right arrow or d, signifys 1, or moving right.

        move.y = Input.GetAxisRaw("Vertical"); // sets the x of the 2d vector to either -1, 0, or 1. If the player is holdinf left arrow-
        //it returns a -1, signifying left. if nothing at all, 0. if right arrow or d, signifys 1, or moving right.

    }


    void FixedUpdate()
    {
        //actual movement
        rb.MovePosition(rb.position + move * movespeed * Time.fixedDeltaTime);
        //access our rigidbody put on the sprite, changes position to the current position + our movement vector * the movement speed *the time since the function was last called

    }

    public void callFromElsewhere()
    {
        //going to need to replace this to trigger dialogue. the TRIGGER WORKS THOUGH.
        transform.position = new Vector3(-1, 2, 0);
    }
}
