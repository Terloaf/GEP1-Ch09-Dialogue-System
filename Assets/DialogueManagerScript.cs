using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DialogueManagerScript : MonoBehaviour
{
    public Queue<string> sentences;

     void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("start conversation with " + dialogue.naming);

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextMessage();
    }

    public void DisplayNextMessage()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log("end of conversation");
    }
}
