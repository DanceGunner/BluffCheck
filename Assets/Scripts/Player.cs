using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int chips;
    public Card[] hand; 


    public Player(string name, int startingChips, Card[] startHand)
    {
        this.playerName = name;
        this.chips = startingChips;
        this.hand = startHand;
    }
}
