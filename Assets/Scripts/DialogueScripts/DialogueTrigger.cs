using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private bool started;

    public void TriggerDialogue()  {
        DialogueManager manager = FindObjectOfType<DialogueManager>();
        if(!started) {
            manager.StartDialogue(dialogue);
            started = true;
        }
    }
}
