﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckHandManager : MonoBehaviour
{
    [SerializeField]
    DeckHand decxHand1Script;
    [SerializeField]
    DeckHand decxHand2Script;
    [SerializeField]
    Sprite backillustlation;
    [SerializeField]
    AnimationManager animationManagerScript;
    
    public void DrawcardAnimation(GameObject drawobj,Vector3 target,GameObject deckobj)
    {
        animationManagerScript.DrawCardAnimation(drawobj,target,deckobj);
    }

    public Sprite BackIllustlation()
    {
        return backillustlation;
    }

    public Vector3 GetInstancePos(int num)
    {
        switch (num)
        {
            case 1:
                return decxHand1Script.GetPos();
            case 2:
                return decxHand2Script.GetPos();
        }
        return Vector3.zero;
    }

    public void DeckHandIni()
    {
        decxHand1Script.Ini();
        decxHand2Script.Ini();
    }


    public void InstanceDrawCard(int num,GameObject drawobj)
    {
        switch (num)
        {
            case 1:
                decxHand1Script.SetDrawObj(drawobj);
                break;
            case 2:
                decxHand2Script.SetDrawObj(drawobj);
                break;
        }
    }

    public void RemoveIllustCard(int num,GameObject target)
    {
        switch (num)
        {
            case 1:
                decxHand1Script.RemoveIllustCard(target);
                break;
            case 2:
                decxHand2Script.RemoveIllustCard(target);
                break;
        }
    }

}
