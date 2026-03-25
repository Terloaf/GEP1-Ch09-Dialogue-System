using UnityEngine;

public class DialogueTrigger : MonoBehaviour, IInteractable
{
    [SerializeField]
    DialogueManagerScript dialougeManager;
    public Dialogue dialogue;

    public bool isTalking = false;

    private void Awake()
    {
        dialougeManager = ServiceHub.Instance.DialogueManagerSript;
    }
    public void Interact()
    {

        if(dialougeManager.inDialogue == true)
        {
            dialougeManager.DisplayNextMessage();
        }
        else
        {
            dialougeManager.StartDialogue(dialogue);
        }
           
      
        
    }

}
