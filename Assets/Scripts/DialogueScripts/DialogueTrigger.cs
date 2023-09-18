using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [TextArea(3, 10)]
    public Dialogue dialogue;

    public void TriggerDialogue()  {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
