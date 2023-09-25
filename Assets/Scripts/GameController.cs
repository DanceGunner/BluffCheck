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
        // Initialize game state here (e.g., set up players, deal hole cards, set blinds, etc.)

    }

    public void ProcessPlayerAction(PlayerAction action)
    {
        
    }
}
