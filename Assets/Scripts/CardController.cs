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
    Page1,
    Page2,
    Page3,
    Page4,
    Page5,
    Page6,
    Page7,
    Page8,
    Page9,
    Page10,
    Page11,
    Page12,
    Page13,
    Page14,
    Page15,
    Page16,
    Page17,
    Page18,
    Page19,
    Page20,
    Page21,
    Page22,
    Page23,
    Page24,
    Page25,
    Page26,
    Page27,
    Page28,
    Page29,
    Page30,
    Page31,
    Page32,
    Page33,
    Page34,
    Page35,
}
