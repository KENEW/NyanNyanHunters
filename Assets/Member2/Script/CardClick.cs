﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private CardComponent card_c;
    private CardField cardField;
    public static bool canClick;

    public enum CardImageType
    {
        Handler,
        Field
    };
    public CardImageType imageType;
    

    void Awake()
    {
        card_c = GetComponent<CardComponent>();
        cardField = FindObjectOfType<CardField>();
        canClick = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        SoundManager.Instance.PlaySFX("UIButton_Sound1");
        if (imageType == CardImageType.Field)
        {
            if (canClick == false) return;
            if (cardField.playerHandler.Count >= 3 || cardField.cardList.Count > 12) return;
            Card card = card_c.card;

            if (card_c.GetIsUsed() == true)
            {
                return;
            }
            else
            {
                cardField.playerHandler.Add(card);
                //cardField.cardList.Remove(card);
                //card_c.DeleteCard();
                card_c.OffCard();
            }
            

            GameManager.Instance.clickedCardCount += 1;

            cardField.UpdateCardPos();
            cardField.UpdateHandler();
        }
        else //if type==handler
        {
            if (card_c.card == null) return;
            Card card = card_c.card;
            cardField.AddCard(card);
            cardField.UpdateCardPos();

            cardField.playerHandler.Remove(card);
            card_c.DeleteCard();

            foreach(Card c in cardField.playerHandler)
            {
                Debug.Log("Debug : " + c.cardName);
            }

            GameManager.Instance.clickedCardCount -= 1;
        }
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {


    }


}
