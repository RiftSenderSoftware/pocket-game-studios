using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CardManager : MonoBehaviour, IDrugHandler
{
    // Studios
    public static int statisticPolice;
    public static int statisticDefend;
    public static int statisticOffice;
    public static int statisticMoney;

    public static int maxValue = 100;
    public int minValue = 0;

    // Date
    public int date;

    // Card Load
    public int changeCards;
    public static int allCards;
    // Game Objects
    public GameObject cardGameObject;

    public CardController cardController;
    public SpriteRenderer cardSpriteRender;
    public ResourceManager resourceManager;
    public Vector2 defaultPositonCard;
    // Twaking variables
    public float fMoovingSpeed;
    public float fRotatingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    public float divideValue;
    public float backgroundDivideValue;

    float alphaText;
    Vector3 pos;
    // UI
    public TMP_Text display;
    public TMP_Text characterDialogue;
    public TMP_Text actionQuote;
    public SpriteRenderer actionBackground;

    public Color textColor;
    public Color actionBackgroundColor;
    public float fTransparency = 0.7f;
    public float fRotationCoefficient;

    //Card Variable
    public string direction;
    private string leftQuote;
    private string rightQuote;
    public Card currentCard;
    public Card testCard;
    // Substiting the card  
    public bool isSubstituting = false;
    public Vector3 cardRotation; // default
    public Vector3 currentRotation; // current rotation the card
    public Vector3 initRotation; // initial rotation of the card


    private void Start()
    {
        LoadCard(testCard);
        //startPos = image.transform.position;
    }
    void UpdateDialogue()
    {
        actionQuote.color = textColor;
        actionBackground.color = actionBackgroundColor;
        if (cardGameObject.transform.position.x < 0)
        {
            actionQuote.text = leftQuote;
        }
        else
        {
            actionQuote.text = rightQuote;
        }
    }
    private void Update()
    {
        MaxValue();

        

        // dialogue text handing
        textColor.a = Mathf.Min(Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin / divideValue, 1);
        actionBackgroundColor.a = Mathf.Min(Mathf.Abs(cardGameObject.transform.position.x) - fSideMargin / backgroundDivideValue, fTransparency);

        if (cardGameObject.transform.position.x > fSideTrigger)
        {
            direction = "Right";
            
            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Right();
                NewCard();
            }
            
        }
        else if (cardGameObject.transform.position.x > fSideMargin)
        {
            direction = "Right";

        }
        else if (cardGameObject.transform.position.x > -fSideMargin)
        {
            direction = "None";
            textColor.a = 0;
            
        }
        else if (cardGameObject.transform.position.x > -fSideTrigger)
        {
            direction = "Left";

        }
        else 
        {
            direction = "Left";

            if (Input.GetMouseButtonUp(0))
            {
                currentCard.Left();
                NewCard();
            }
        }
        UpdateDialogue();

        // ��������
        if (Input.GetMouseButton(0) && cardController.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
            cardGameObject.transform.eulerAngles = new Vector3(0, 0, cardGameObject.transform.position.x * fRotationCoefficient);

        }
        else if(!isSubstituting)
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, defaultPositonCard, fMoovingSpeed);
            cardGameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (isSubstituting)
        {
            cardGameObject.transform.eulerAngles = Vector3.MoveTowards(cardGameObject.transform.eulerAngles, cardRotation, fRotatingSpeed);

        }

        //UI
        display.text = "" + textColor.a;

        characterDialogue.text = currentCard.dialogue;

        //Rotating the card
        if(cardGameObject.transform.eulerAngles == cardRotation)
        {
            isSubstituting = false;
        }


    }

    public void LoadCard(Card card)
    {
        cardSpriteRender.sprite = resourceManager.sprites[(int)card.sprite];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        currentCard = card;
        characterDialogue.text = card.dialogue;
        // Reseting position of the card
        cardGameObject.transform.position = defaultPositonCard;
        cardGameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        // Init if the substition
        isSubstituting = true;
        cardGameObject.transform.eulerAngles = initRotation;
    }

    public void NewCard()
    {
        /* randomize system
        date += 1;
        InterfaceManager cse = FindObjectOfType<InterfaceManager>();
        cse.dateTMPro.text = "" + date;
        LoadCard(resourceManager.cards[rollDice]);

        int rollDice = Random.Range(0, resourceManager.cards.Length);
        */
        allCards = resourceManager.cards.Length;

        if (changeCards < allCards)
        {
            changeCards++;
            LoadCard(resourceManager.cards[changeCards]);
        }
        if(changeCards >= allCards)
        {
            SceneManager.LoadScene(0);
        }
    }
    // Values logic
    public void MaxValue()
    {
        if (statisticPolice >= 100) { statisticPolice = 100; }
        if (statisticPolice <= 0) { statisticPolice = 0; }

        if (statisticDefend >= 100) { statisticDefend = 100; }
        if (statisticDefend <= 0) { statisticDefend = 0; }

        if (statisticOffice >= 100) { statisticOffice = 100; }
        if (statisticOffice <= 0) { statisticOffice = 0; }

        if (statisticMoney >= 100) { statisticMoney = 100; }
        if (statisticMoney <= 0) { statisticMoney = 0; }

        
        if (minValue <= 0) { minValue = 0; Debug.Log("Min:" + minValue); }
        if (maxValue >= 100) { maxValue = 100; Debug.Log("Max:" + maxValue); }
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector2(transform.localPosition.x + eventData.delta.x, transform.localPosition.y);
    }
}
