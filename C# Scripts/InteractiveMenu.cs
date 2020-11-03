using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class InteractiveMenu : MonoBehaviour
{

    public GameObject[] buttons = new GameObject[6]; //Makes an array of buttons for all of our options (Chat, steal, etc.)

    public GameObject source; //Makes a source object

    public bool clicked = false; //Makes an object to detect if we already clicked it or not and if we need to create more instances of our menu buttons prefabs

    void OnMouseDown() //checks to see if mouse was clicked
    {
        if (clicked == false) //checks to see if the source object has already been clicked
        {
            for (int i = 0; i < buttons.Length; i++) //loops through the arrays of buttons
            {
                Instantiate(buttons[i]); //creates instances of each of the buttons
            }
            float sourceX = source.transform.position.x; 
            float sourceY = source.transform.position.y;
            buttons[0].transform.position = new Vector3(sourceX + (float)0.75, sourceY + (float)0.5, 0); //moves the chat button
            buttons[1].transform.position = new Vector3(sourceX + 1, sourceY, 0); //moves the steal button
            buttons[2].transform.position = new Vector3(sourceX + (float)0.75, sourceY - (float)0.5, 0); //moves the bribe button
            buttons[3].transform.position = new Vector3(sourceX - (float)0.75, sourceY - (float)0.5, 0); //moves the poison button
            buttons[4].transform.position = new Vector3(sourceX - 1, sourceY, 0); //moves the knock out button
            buttons[5].transform.position = new Vector3(sourceX - (float)0.75, sourceY + (float)0.5, 0); //moves the stab button
            clicked = true; //sets clicked to be true, so no more instances are made from this object until another thing is clicked
        }
    }
}
