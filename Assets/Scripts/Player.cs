using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int chips;
    public Card[] hand; 


    public void InitializePlayer(string playerName, int startingChips, Card[] hand)
    {
        this.playerName = playerName;
        this.chips = startingChips;
        this.hand = hand;
    }
}
