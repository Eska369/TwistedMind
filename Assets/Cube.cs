using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Cube : MonoBehaviour
{
    public NPCConversation myConversation;

    public GameObject siekiera;
    

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(myConversation);
            Debug.Log("dziala to czy nie wrr");
            siekiera.transform.Rotate(0.0f, 0.0f, 45.0f);
            siekiera.transform.Rotate(0.0f, 0.0f, 90.0f);
        }
    }
}
