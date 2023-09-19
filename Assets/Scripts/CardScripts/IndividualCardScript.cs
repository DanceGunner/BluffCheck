using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IndividualCardScript : MonoBehaviour
{
    public Sprite cardBack;
    public Sprite cardFront;
    private Sprite currentFace;

    // Start is called before the first frame update
    void Start()
    {
        currentFace = GetComponent<Image>().sprite;
        FlipToBack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipToFront()
    {
        GetComponent<Image>().sprite = cardFront;
    }

    public void FlipToBack()
    {
        GetComponent<Image>().sprite = cardBack;
    }
}
