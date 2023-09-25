using UnityEngine;
using System.Collections.Generic;

public enum CardSuit
{
    Hearts,
    Diamonds,
    Clubs,
    Spades
}

public class Card : MonoBehaviour
{
    private int value;
    private CardSuit suit;

    public Card(int value, CardSuit suit)
    {
        this.value = value;
        this.suit = suit;
    }

    public int getValue()
    {
        return this.value;
    }

    public CardSuit getSuit()
    {
        return this.suit;
    }
}
