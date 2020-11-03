using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public string name; //name of the button (Chat, steal, etc.)

    public GameObject source; //the source of the click (A character, a barrel, etc.)

    public InteractiveMenu otherScript; //gets the interactive menu from the source to mark if it has already been clicked or not

    void OnMouseDown() //checks if mouse was clicked
    {
        if(name == "Chat") //checks to see if name is a certain button
        {
            Debug.Log("Worked chat"); //debugs showing that the programming following up clicking a certain button works
        } else if(name == "Steal") //checks to see if name is a certain button
        {
            Debug.Log("Worked steal"); //debugs showing that the programming following up clicking a certain button works
        } else if(name == "Bribe") //checks to see if name is a certain button
        {
            Debug.Log("Worked bribe"); //debugs showing that the programming following up clicking a certain button works
        } else if(name == "Poison") //checks to see if name is a certain button
        {
            Debug.Log("Worked poison"); //debugs showing that the programming following up clicking a certain button works
        } else if(name == "Knock Out") //checks to see if name is a certain button
        {
            Debug.Log("Worked knock out"); //debugs showing that the programming following up clicking a certain button works
        } else if(name == "Stab") //checks to see if name is a certain button
        {
            Debug.Log("Worked Stab"); //debugs showing that the programming following up clicking a certain button works
        }
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

    void Start()
    {
        source = GameObject.FindWithTag("clickable"); //Finds our single object with the tag clickable (meaning its the object with our interactive script)
        otherScript = source.GetComponent<InteractiveMenu>(); //Sets our otherScript to be the interactive script of the source object
    }
}