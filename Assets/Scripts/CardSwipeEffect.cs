using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardSwipeEffect : MonoBehaviour, IDrugHandler
{
    // public GameObject image;
    //private Vector3 startPos;
    //private float swipeThreshold = 50f;

    
    public GameObject image;           // ������ �� ������ �����������
    private Vector2 startPos;          // ��������� ������� ������
    private Vector2 endPos;            // �������� ������� ������
    private float swipeThreshold = 50f; // ����� ������ ��� ����������� ��������
    private bool isSwiping = false;     // ���� ��� ������������ ������
    

    public GameObject cardGameObject;
    public CardController cardController;
    public SpriteRenderer cardSpriteRender;
    public ResourceManager resourceManager;

    public float fMoovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    public float divideValue;

    float alphaText;
    Vector3 pos;
    public TMP_Text display;
    public TMP_Text characterDialogue;
    public TMP_Text acrionQuote;

    public Color textColor;

    private string leftQuote;
    private string rightQuote;

    public Card currentCard;
    public Card testCard;

    private void Start()
    {
        LoadCard(testCard);
        //startPos = image.transform.position;
    }
    void UpdateDialogue()
    {
        acrionQuote.color = textColor;

        if (cardGameObject.transform.position.x < 0)
        {
            acrionQuote.text = leftQuote;
        }
        else
        {
            acrionQuote.text = rightQuote;
        }
    }
    private void Update()
    {
        textColor.a = Mathf.Min(Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin / divideValue, 1);

        if (cardGameObject.transform.position.x > fSideTrigger)
        {
            
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Right();

            }
        }
        else if (cardGameObject.transform.position.x > fSideMargin)
        {
            
        }
        else if (cardGameObject.transform.position.x > -fSideMargin)
        {
            textColor.a = 0;
            
        }
        else if (cardGameObject.transform.position.x > -fSideTrigger)
        {
            
        }
        else 
        {

            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Left();
                NewCard();
            }
        }
        UpdateDialogue();

        //Movement
        if (Input.GetMouseButton(0) && cardController.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
        }
        else
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, new Vector2(0,1), fMoovingSpeed);
        }
        /* //OLD CODE
        if(cardGameObject.transform.position.x > fSideMargin)
        {
            dialogue.text = rightQuote;
            //dialogue.alpha = Mathf.Min(cardGameObject.transform.position.x, 1);
            
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                currentCard.Right();
                Debug.Log("right");
            }

        } else if (cardGameObject.transform.position.x < -fSideMargin)
        {
            dialogue.text = leftQuote;

            //dialogue.alpha = Mathf.Min(-cardGameObject.transform.position.x, 1);

            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                currentCard.Right();

                Debug.Log("left");
            }
        }
        else
        {
            //card.color = Color.white;
        }
        */
        //UI
        display.text = "" + textColor.a;

        
    }

   public void LoadCard(Card card)
    {
        cardSpriteRender.sprite = resourceManager.sprites[(int)card.sprite];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        currentCard = card;
        characterDialogue.text = card.dialogue;
    }

    public void NewCard()
    {
        int rollDice = Random.Range(0, resourceManager.cards.Length);
        LoadCard(resourceManager.cards[rollDice]);
    }

    /*
    private void FunTwo()
    {
        if (Input.GetMouseButtonDown(0))      // ��������� ������� ����� ������ ����/���������
        {
            startPos = Input.mousePosition;  // ��������� ��������� ������� ������
            isSwiping = true;                // ������������� ���� ������
        }
        else if (Input.GetMouseButtonUp(0))   // ��������� ���������� ����� ������ ����/���������
        {
            endPos = Input.mousePosition;    // ��������� �������� ������� ������

            Vector2 swipeDirection = endPos - startPos;     // ��������� ������ ����������� ������

            if (swipeDirection.magnitude > swipeThreshold)  // ���� ����� ������� ������ ������ ������
            {
                if (swipeDirection.x > 0)           // ���� ����� ������
                {
                    Debug.Log("Swipe right");
                    // �������� ��� ������ ������ (��������, ����)
                }
                else                                // ���� ����� �����
                {
                    Debug.Log("Swipe left");
                    // �������� ��� ������ ����� (��������, �������)
                }
            }

            isSwiping = false;           // ���������� ���� ������
        }

        if (isSwiping)
        {
            Vector2 delta = (Vector2)Input.mousePosition - startPos;   // ��������� ������� ����� ������� �������� � ��������� �������� ������

            image.transform.position = startPos + delta;   // ��������� ������� ����������� � ������������ � �������� ������
        }
    }
    */

    /*
private void FuncOne()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - startPos;
            if (delta.magnitude > swipeThreshold)
            {
                if (delta.x > 0)
                {
                    Debug.Log("Right");

                }
                else
                {
                    Debug.Log("left");
                }
                image.transform.position = startPos;
            }
        }
    }
    */
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(transform.localPosition.x + eventData.delta.x, transform.localPosition.y);
    }
}
