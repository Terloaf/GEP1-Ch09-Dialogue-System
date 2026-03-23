using UnityEngine;

public class DialogueTrigger : MonoBehaviour, IInteractable
{

    public Dialogue dialogue;
    public bool isTalking = false;
    public void Interact()
    {
        if(isTalking == false)
        {
            ServiceHub.Instance.DialogueManagerSript.StartDialogue(dialogue);
            
        }
        if (isTalking == true)
        {
            ServiceHub.Instance.DialogueManagerSript.DisplayNextMessage();
        }
        isTalking = true;
    }

}
