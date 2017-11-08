﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour {

    [SerializeField]
    DeckClass player1Deck;

    [SerializeField]
    DeckClass player2Deck;

    public GameObject GetDrawObj(int number)
    {
        Debug.Log(number);
        switch (number)
        {
            case 1:
                return player1Deck.GetCharacter();
                break;
            case 2:
                return player2Deck.GetCharacter();
                break;
        }
        return null; 
    }
}