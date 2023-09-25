using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    public List<Player> players;
    public List<Card> communityCards;

    private int currentBettingRound;
    private int currentBet;
    private int communityPot;

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Initialize game state here
        Player.Add(new Player("Deagan Fox Mann"), 10, new Card[] { new Card(2, 0), new Card(7, 1) });
        Player.Add(new Player("Chet"), 100, new Card[] { new Card(5, 3), new Card(12, 2) });
        communityCards.AddRange(new Card[] {new Card(1, 3), new Card(12, 3), new Card(9, 2), new Card(3, 3), new Card(10, 1)});
    }
}
