using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class InteractiveMenu : MonoBehaviour
{
    public string nameOfObject; //Makes a name variable

    public GameObject[] buttons = new GameObject[6]; //Makes an array of buttons for all of our options (Chat, steal, etc.)

    public GameObject source; //Makes a source object

    public bool clicked = false; //Makes an object to detect if we already clicked it or not and if we need to create more instances of our menu buttons prefabs

    public GameObject[] click;

    public bool clickedTwice = false;

    public MenuButton me;

    public int m = 0;

    public int countClick = 0;

    void OnMouseDown() //checks to see if mouse was clicked
    {
        if (clicked == false)
        {
            countClick = 1;
            click = GameObject.FindGameObjectsWithTag("clickable");
            foreach (GameObject c in click)
            {
                clicked = false;
            }
            click = GameObject.FindGameObjectsWithTag("button");
            foreach (GameObject b in click)
            {
                Destroy(b);
            }
            if (countClick == 1)
            {
                countClick++;
                clickedTwice = false;
            }
            if (countClick == 2)
            {
                countClick--;
                clickedTwice = true;
            }
        }
        if (clickedTwice == false)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Destroy(buttons[i]);
            }
        }
        if (clickedTwice == true) //checks to see if the source object has already been clicked
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
            clicked = false; //sets clicked to be true, so no more instances are made from this object until another thing is clicked
            me.StartButton(nameOfObject, m);
            clickedTwice = false;
        }
    }
}
