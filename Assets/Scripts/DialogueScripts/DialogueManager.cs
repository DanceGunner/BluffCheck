using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    private bool hasChoices = false;

    private Dialogue[] choices;

    public Text nameText;

    public Text dialogueText;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue) {
        Debug.Log("Starting conversation with" + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        if(dialogue.choices.Length> 0) {
            hasChoices = true;
            choices = dialogue.choices;
        }

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if(sentences.Count == 0) {
            if(!hasChoices) {
                EndDialogue();
            }
            return;
        }

        string sentence = sentences.Dequeue();


        Debug.Log(sentence);
        dialogueText.text = sentence;
    }

    public void EndDialogue() {
        Debug.Log("End of Conversation");
    }

    public void OnClickRaise() {
        StartDialogue(choices[0]);
    }

    public void OnClickCheck() {
        StartDialogue(choices[1]);
    }

    public void OnClickFold() {
        StartDialogue(choices[2]);
    }

}
