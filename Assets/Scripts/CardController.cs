using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CardController : MonoBehaviour
{

    public Card card;
    public BoxCollider2D thisCard;
    public bool isMouseOver;

    private void Start()
    {
        thisCard = gameObject.GetComponent<BoxCollider2D>();
    }

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

}



public enum CardSprite
{
    MONEYMAN,
    ICECREAMMAN,
    HORNYGIRL,
    SMOKIMGMAN,
    SERIOSLIGIRL,
    PISTOLMAN,
    SITMAN
}
