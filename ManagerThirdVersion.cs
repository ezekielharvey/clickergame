using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
 
 
public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;
    public GameObject buttonActivation;
    public Button upgradeButton1, upgradeButton2, upgradeButton3, upgradeButton4;
 
    float TotalClicks;
 
    bool hasUpgrade, hasUpgrade2, hasUpgrade3, hasUpgrade4;
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade, minimumClicksToUnlockUpgrade2, minimumClicksToUnlockUpgrade3, minimumClicksToUnlockUpgrade4;
 
    public void Start()
    {
        upgradeButton1.interactable = false;
 
        upgradeButton2.interactable = false;
 
        upgradeButton3.interactable = false;
 
        upgradeButton4.interactable = false;
    }
 
    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
 
        if(TotalClicks >= minimumClicksToUnlockUpgrade) {
            upgradeButton1.interactable = true;
        }
 
        if(TotalClicks >= minimumClicksToUnlockUpgrade2) {
            upgradeButton2.interactable = true;
        }
 
        if(TotalClicks >= minimumClicksToUnlockUpgrade3) {
            upgradeButton3.interactable = true;
        }
 
        if(TotalClicks >= minimumClicksToUnlockUpgrade4) {
            upgradeButton4.interactable = true;
        }
    }
 
    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade;
            hasUpgrade = true;
        }
    }
 
    public void AutoClickUpgrade2()
    {
        if(!hasUpgrade2 && TotalClicks >= minimumClicksToUnlockUpgrade2)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade2;
            hasUpgrade2 = true;
        }
    }
    public void AutoClickUpgrade3()
    {
        if(!hasUpgrade3 && TotalClicks >= minimumClicksToUnlockUpgrade3)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade3;
            hasUpgrade3 = true;
        }
    }
 
    public void AutoClickUpgrade4()
    {
        if(!hasUpgrade4 && TotalClicks >= minimumClicksToUnlockUpgrade4)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade4;
            hasUpgrade4 = true;
        }
    }
 
    public void activateButton()
    {
        if(TotalClicks < minimumClicksToUnlockUpgrade)
        {
            upgradeButton1.interactable = false;
        }
        else if(!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            upgradeButton1.interactable = true;
        }
        else
        {
            upgradeButton1.interactable = true;
        }
    }
   
    public void activateButton2()
    {
        if(TotalClicks < minimumClicksToUnlockUpgrade2)
        {
            upgradeButton2.interactable = false;
        }
        else if(!hasUpgrade2 && TotalClicks >= minimumClicksToUnlockUpgrade2)
        {
            upgradeButton2.interactable = true;
        }
        else
        {
            upgradeButton2.interactable = true;
        }
    }
 
    public void activateButton3()
    {
        if(TotalClicks < minimumClicksToUnlockUpgrade3)
        {
            upgradeButton3.interactable = false;
        }
        else if(!hasUpgrade3 && TotalClicks >= minimumClicksToUnlockUpgrade3)
        {
            upgradeButton3.interactable = true;
        }
        else
        {
            upgradeButton3.interactable = true;
        }
    }
 
    public void activateButton4()
    {
        if(TotalClicks < minimumClicksToUnlockUpgrade4)
        {
            upgradeButton4.interactable = false;
        }
        else if(!hasUpgrade4 && TotalClicks >= minimumClicksToUnlockUpgrade4)
        {
            upgradeButton4.interactable = true;
        }
        else
        {
            upgradeButton4.interactable = true;
        }
    }
 
    private void Update()
    {
 
        if(hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;
 
            ClicksTotalText.text = TotalClicks.ToString("0");
 
            upgradeButton1.interactable = false;
        }
 
        if(hasUpgrade2)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 2;
 
            ClicksTotalText.text = TotalClicks.ToString("0");
 
            upgradeButton2.interactable = false;
        }
 
        if(hasUpgrade3)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 4;
 
            ClicksTotalText.text = TotalClicks.ToString("0");
 
            upgradeButton3.interactable = false;
        }
 
        if(hasUpgrade4)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 8;
 
            ClicksTotalText.text = TotalClicks.ToString("0");
 
            upgradeButton4.interactable = false;
        }
    }
}
