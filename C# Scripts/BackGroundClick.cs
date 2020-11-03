using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundClick : MonoBehaviour
{

    public InteractiveMenu otherScript; //makes an interactive menu object, which we set to be whatever the source of our click to be (Character, Barrel, etc.)

    void OnMouseDown() //checks to see if we clicked the background (set the background to be bigger than everything else)
    {
        GameObject other = GameObject.Find("Chat(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        other = GameObject.Find("Steal(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        other = GameObject.Find("Bribe(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        other = GameObject.Find("Knock Out(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        other = GameObject.Find("Poison(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        other = GameObject.Find("Stab(Clone)"); //Finds a certain button with a name
        Destroy(other); //Destroys the object since we are done with it
        otherScript.clicked = false; //Makes it to where we can click the source again without duplicating buttons
    }
}
