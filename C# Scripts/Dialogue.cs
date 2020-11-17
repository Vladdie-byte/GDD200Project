using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{

    public string name;

    public GameObject check;

    public GameObject[] checkList;

    public string nameOfO;

    [TextArea(3, 10)]
    public string[] sentences;

    /*public string[] getDialogue(string nameOfObject)
    {
        GameObject.FindGameObjectsWithTag("clickable");
        for (int i = 0; i < checkList.Length; i++)
        {
            if(nameOfObject == nameOfO)
            {
                return sentences;
            }
        }
        return null;
    }*/
}