using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    GameObject Dummy;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Dummy = GameObject.FindWithTag("NPC");
        Player = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("In Range");
        Dummy.SetActive(false);
        Character2dController theOtherScript = Player.GetComponent<Character2dController>();
        theOtherScript.callFromElsewhere();
    }
}
