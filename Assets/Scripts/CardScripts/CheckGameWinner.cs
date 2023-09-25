using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class CheckGameWinner : MonoBehaviour
{
    public List<Card> playerHand; // Player's hand
    public List<Card> communityCards; // Community cards

    public bool CheckForWin()
    {
        List<Card> allCards = new List<Card>();
        allCards.AddRange(playerHand);
        allCards.AddRange(communityCards);

        // Sort the cards by their values
        allCards.Sort((a, b) => a.getValue().CompareTo(b.getValue()));

        // Check for win conditions
        if (CheckForStraightFlush(allCards)) return true;
        if (CheckForFourOfAKind(allCards)) return true;
        if (CheckForFullHouse(allCards)) return true;
        if (CheckForFlush(allCards)) return true;
        if (CheckForStraight(allCards)) return true;
        if (CheckForThreeOfAKind(allCards)) return true;
        if (CheckForTwoPairs(allCards)) return true;
        if (CheckForPair(allCards)) return true;

        return false;
    }

    private bool CheckForPair(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 1; i++)
        {
            if (cards[i].getValue() == cards[i + 1].getValue())
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckForTwoPairs(List<Card> cards)
    {
        int pairs = 0;
        for (int i = 0; i < cards.Count - 1; i++)
        {
            if (cards[i].getValue() == cards[i + 1].getValue())
            {
                pairs++;
                i++;
            }
        }
        return pairs >= 2;
    }

    private bool CheckForThreeOfAKind(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 2; i++)
        {
            if (cards[i].getValue() == cards[i + 1].getValue() && cards[i].getValue() == cards[i + 2].getValue())
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckForStraight(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 4; i++)
        {
            if (cards[i + 4].getValue() - cards[i].getValue() == 4)
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckForFlush(List<Card> cards)
    {
        Dictionary<int, int> suitsCount = new Dictionary<int, int>();
        foreach (Card card in cards)
        {
            if (!suitsCount.ContainsKey(card.getSuit()))
            {
                suitsCount[card.getSuit()] = 0;
            }
            suitsCount[card.getSuit()]++;
            if (suitsCount[card.getSuit()] >= 5)
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckForFullHouse(List<Card> cards)
    {
        if (cards[0].getValue() == cards[1].getValue() && cards[1].getValue() == cards[2].getValue() &&
            cards[3].getValue() == cards[4].getValue())
        {
            return true;
        }
        if (cards[0].getValue() == cards[1].getValue() &&
            cards[2].getValue() == cards[3].getValue() && cards[3].getValue() == cards[4].getValue())
        {
            return true;
        }
        return false;
    }

    private bool CheckForFourOfAKind(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 3; i++)
        {
            if (cards[i].getValue() == cards[i + 1].getValue() && cards[i + 1].getValue() == cards[i + 2].getValue() &&
                cards[i + 2].getValue() == cards[i + 3].getValue())
            {
                return true;
            }
        }
        return false;
    }

    private bool CheckForStraightFlush(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 4; i++)
        {
            if (cards[i + 4].getValue() - cards[i].getValue() == 4 && CheckForFlush(cards.GetRange(i, 5)))
            {
                return true;
            }
        }
        return false;
    }
}
