using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

public class DialogueManagerScript : MonoBehaviour
{
    public Queue<string> sentences;
    public string _name;
    public bool inDialogue = false;

    [SerializeField]
    private UIManager ui;

    [SerializeField]
    private PlayerMovementController player;
    private void Awake()
    {
        ui = ServiceHub.Instance.UIManager;
        player = ServiceHub.Instance.Player.GetComponent<PlayerMovementController>();
    }
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        name = dialogue.naming;
        Debug.Log("start conversation with " + dialogue.naming);


        inDialogue = true;
        player.moveEnabled = false;
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
        Debug.Log(sentences.Count);
        Debug.Log(sentence);
        ui.dialogueText.text = name + ": " + sentence;
        ui.ShowDialoguePanel();

    }

    void EndDialogue()
    {
        sentences.Clear();
        ui.HideDialoguePanel();
        player.moveEnabled = true;
        Debug.Log("end of conversation");

        inDialogue = false;
  
    }


}
