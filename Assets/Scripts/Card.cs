using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public int cardID;
    public string cardName;
    public CardSprite sprite;
    public string dialogue;

    public string leftQuote;
    public string rightQuote;
    public void Left()
    {
        UnityEngine.Debug.Log(cardName + "swipe right");
    }
    public void Right()
    {
        UnityEngine.Debug.Log(cardName + "swipe right");

    }
}
