using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    private bool hasChoices = false;

    private Dialogue[] choices;
    
    private string[] choiceNames;

    public Text nameText;

    public Text dialogueText;

    public Text raise;
    public Text check;
    public Text fold;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        choices = new Dialogue[3];
        choiceNames = new string[3];
    }
    public void StartDialogue(Dialogue dialogue) {
        Debug.Log("Starting conversation with" + dialogue.name);

        //Reset the state
        nameText.text = dialogue.name;

        Array.Clear(choices, 0, 3);
        Array.Clear(choiceNames, 0, 3);

        sentences.Clear();

        if(dialogue.choices.Length> 0) {
            hasChoices = true;
            choices = dialogue.choices;
            choiceNames = dialogue.choiceNames;
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
            else {
                raise.text = choiceNames[0];
                check.text = choiceNames[1];
                fold.text = choiceNames[2];
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
