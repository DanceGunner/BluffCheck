using UnityEngine;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    private int value;
    // 0 - Hearts
    // 1 - Spades
    // 2 - Diamonds
    // 3 - Clubs
    private int suit;

    public Card(int value, int suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public int getValue()
    {
        return this.value;
    }

    public int getSuit()
    {
        return this.suit;
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
