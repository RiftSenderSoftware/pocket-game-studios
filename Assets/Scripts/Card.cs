using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    //Basic card values
    public int cardID;
    public string cardName;
    public CardSprite sprite;
    public string dialogue;

    public string leftQuote;
    public string rightQuote;

    // Impact values
    public int sPolice;
    public int sDefend;
    public int sOffice;
    public int sMoney;
    public void Left()
    {
        UnityEngine.Debug.Log(cardName + "swipe left");
    }
    public void Right()
    {
        UnityEngine.Debug.Log(cardName + "swipe right");

    }
}
