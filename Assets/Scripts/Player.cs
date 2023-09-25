using UnityEngine;

public enum PlayerAction
{
    Fold,
    Check,
    Bet,
    Call,
    Raise
}

public class Player : MonoBehaviour
{
    public string playerName;
    public int chips;
    public Card[] hand; 


    public void InitializePlayer(string playerName, int startingChips)
    {
        this.playerName = playerName;
        this.chips = startingChips;
        hand = new Card[] { new Card(2, CardSuit.Hearts), new Card(7, CardSuit.Spades) };
    }
}
