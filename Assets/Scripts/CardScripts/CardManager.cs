using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public Image playerCard1;
    public Image playerCard2;
    public Image opponentCard1;
    public Image opponentCard2;
    public Image fieldCard1;
    public Image fieldCard2;
    public Image fieldCard3;
    public Image fieldCard4;
    public Image fieldCard5;
    private List<Image> cardsInGame;
    public int roundNum;
    public int roundStage;
    private Dictionary<string, Sprite> cardSprites;

    // Start is called before the first frame update
    void Start()
    {
        cardsInGame = new List<Image> { playerCard1, playerCard2, opponentCard1, opponentCard2, fieldCard1,
                                        fieldCard2, fieldCard3, fieldCard4, fieldCard5 };
        cardSprites = LoadCardSprites();
        roundNum = 0;
        roundStage = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetUpRound(List<Sprite> cardsForRound)
    {
        for (int i = 0; i < cardsInGame.Count; i++)
        {
            cardsInGame[i].GetComponent<IndividualCardScript>().FlipToBack();
            cardsInGame[i].GetComponent<IndividualCardScript>().cardFront = cardsForRound[i];
        }
    }

    public void StartNextRound()
    {
        Console.WriteLine(cardsInGame.Count);
        List<Sprite> cards;
        // for each case you will want to set the cards list to be the desired cards for the game
        // in this order player left card, player right card, opponent left card, opponnent right,
        // field cards from left to right. case 1 will be the first game and so on.
        switch (roundNum)
        {
            case 0:
                cards = new List<Sprite> { cardSprites["club10"], cardSprites["club9"], cardSprites["spadeK"],
                                           cardSprites["heartA"], cardSprites["clubA"], cardSprites["heart10"],
                                           cardSprites["spade5"], cardSprites["heart9"], cardSprites["spade9"], };
                SetUpRound(cards);
                break;
            case 1:
                cards = new List<Sprite> {  cardSprites["club10"], cardSprites["club9"], cardSprites["spadeK"],
                                           cardSprites["heartA"], cardSprites["clubA"], cardSprites["heart10"],
                                           cardSprites["spade5"], cardSprites["heart9"], cardSprites["spade9"], };
                SetUpRound(cards);
                break;
            case 2:
                cards = new List<Sprite> { cardSprites["club10"], cardSprites["club9"], cardSprites["spadeK"],
                                           cardSprites["heartA"], cardSprites["clubA"], cardSprites["heart10"],
                                           cardSprites["spade5"], cardSprites["heart9"], cardSprites["spade9"], };
                SetUpRound(cards);
                break;
        }
        roundNum++;
        roundStage = 0;
    }

    public void ReveilNextcards()
    {
        switch (roundStage)
        {
            case 0:
                ReveilPlayerCards();
                break; 
            case 1:
                ReveilFieldCardsStage1();
                break; 
            case 2:
                ReveilFieldCardsStage2();
                break;
            case 3:
                ReveilFieldCardsStage3();
                break;
            case 4:
                ReveilOpponentCards();
                break;
            case 5:
                StartNextRound();
                roundStage = -1;
                break;
        }
        roundStage++;
    }

    void ReveilPlayerCards()
    {
        playerCard1.GetComponent<IndividualCardScript>().FlipToFront();
        playerCard2.GetComponent<IndividualCardScript>().FlipToFront();
    }

    void ReveilOpponentCards()
    {
        opponentCard1.GetComponent<IndividualCardScript>().FlipToFront();
        opponentCard2.GetComponent<IndividualCardScript>().FlipToFront();
    }

    void ReveilFieldCardsStage1()
    {
        fieldCard1.GetComponent<IndividualCardScript>().FlipToFront();
        fieldCard2.GetComponent<IndividualCardScript>().FlipToFront();
        fieldCard3.GetComponent<IndividualCardScript>().FlipToFront();
    }

    void ReveilFieldCardsStage2()
    {
        fieldCard4.GetComponent<IndividualCardScript>().FlipToFront();
    }

    void ReveilFieldCardsStage3()
    {
        fieldCard5.GetComponent<IndividualCardScript>().FlipToFront();
    }



    static Dictionary<string, Sprite> LoadCardSprites()
    {
        Dictionary<string, Sprite> tempCards = new Dictionary<string, Sprite>();
        string cardpath = "TempCardImages/";
        tempCards.Add("club10" ,Resources.Load<Sprite>("cardClubs_10"));
        tempCards.Add("club9" ,Resources.Load<Sprite>(cardpath + "cardClubs_9"));
        tempCards.Add("heartA" ,Resources.Load<Sprite>(cardpath + "cardHearts_A"));
        tempCards.Add("spadeK" ,Resources.Load<Sprite>(cardpath + "cardSpades_K"));
        tempCards.Add("clubA" ,Resources.Load<Sprite>(cardpath + "cardClubs_A"));
        tempCards.Add("heart10" ,Resources.Load<Sprite>(cardpath + "cardHearts_10"));
        tempCards.Add("spade5" ,Resources.Load<Sprite>(cardpath + "cardSpades_5"));
        tempCards.Add("heart9" ,Resources.Load<Sprite>(cardpath + "cardHearts_9"));
        tempCards.Add("spade9" ,Resources.Load<Sprite>(cardpath + "cardSpades_9"));
        return tempCards;
        // load in all the cards??
    }
}
