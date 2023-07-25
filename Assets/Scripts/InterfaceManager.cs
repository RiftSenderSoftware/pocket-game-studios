//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public CardSwipeEffect gameManager;
    public GameObject card;

    public Image statisticPolice;
    public Image statisticDefend;
    public Image statisticOffice;
    public Image statisticMoney;

    // UI Impact
    public Image statisticPoliceImpact;
    public Image statisticDefendImpact;
    public Image statisticOfficeImpact;
    public Image statisticMoneyImpact;
    // Update is called once per frame
    void Update()
    {
        statisticPolice.fillAmount = (float) CardSwipeEffect.statisticPolice / CardSwipeEffect.maxValue;
        statisticDefend.fillAmount = (float)CardSwipeEffect.statisticDefend / CardSwipeEffect.maxValue;
        statisticOffice.fillAmount = (float)CardSwipeEffect.statisticOffice / CardSwipeEffect.maxValue;
        statisticMoney.fillAmount = (float)CardSwipeEffect.statisticMoney / CardSwipeEffect.maxValue;

        // Right
        if(gameManager.direction == "Right")
        {
            if(gameManager.currentCard.sPoliceRight != 0)
                statisticPoliceImpact.transform.localScale = new Vector3(1, 1, 0);
            if(gameManager.currentCard.sDefendRight != 0)
                statisticDefendImpact.transform.localScale = new Vector3(1, 1, 0);
            if(gameManager.currentCard.sOfficeRight != 0)
                statisticOfficeImpact.transform.localScale = new Vector3(1, 1, 0);
            if(gameManager.currentCard.sMoneyRight != 0)
                statisticMoneyImpact.transform.localScale = new Vector3(1, 1, 0);
        }    
        else if (gameManager.direction == "Left")
        {
            if (gameManager.currentCard.sPoliceLeft != 0)
                statisticPoliceImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.sDefendLeft != 0)
                statisticDefendImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.sOfficeLeft != 0)
                statisticOfficeImpact.transform.localScale = new Vector3(1, 1, 0);
            if (gameManager.currentCard.sMoneyLeft != 0)
                statisticMoneyImpact.transform.localScale = new Vector3(1, 1, 0);
        }
        else
        {
            statisticPoliceImpact.transform.localScale = Vector3.zero;
            statisticDefendImpact.transform.localScale = Vector3.zero;
            statisticOfficeImpact.transform.localScale = Vector3.zero;
            statisticMoneyImpact.transform.localScale = Vector3.zero;
        }
    }
}
