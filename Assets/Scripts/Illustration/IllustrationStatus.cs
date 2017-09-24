﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllustrationStatus : MonoBehaviour {

    [SerializeField]
    int playerNumber;
    [SerializeField]
    int dictionaryNumber;
    [SerializeField]
    int rateNumber;
    [SerializeField]
    int costNumber;

    public int GetPlayerNumber()
    {
        return playerNumber;
    }

    public int GetDictionaryNumber()
    {
        return dictionaryNumber;
    }

    public int GetRateNum()
    {
        return rateNumber;
    }

    public void GetRate_Dictionary_Cost_Player_Number(ref int ratenum ,ref int dictionarynum,ref int costnum,ref int playernum)
    {
        ratenum = rateNumber;
        dictionarynum = dictionaryNumber;
        costnum = costNumber;
        playernum = playerNumber;
    }    
}
