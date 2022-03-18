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
    public Button autoclick1, autoclick2, autoclick3, autoclick4, clickPower1, clickPower2, clickPower3, clickPower4;

    float TotalClicks;

    bool hasAutoClick1, hasAutoClick2, hasAutoClick3, hasAutoClick4, hasClickPower1, hasClickPower2, hasClickPower3, hasClickPower4;
    public int autoClicksPerSecond;
    public int autoclickUpgrade, autoclickUpgrade2, autoclickUpgrade3, autoclickUpgrade4, clickpowerUpgrade1, clickpowerUpgrade2, clickpowerUpgrade3, clickpowerUpgrade4;

    public void Start()
    {
        autoclick1.interactable = false;

        autoclick2.interactable = false;

        autoclick3.interactable = false;

        autoclick4.interactable = false;

        clickPower1.interactable = false;

        clickPower2.interactable = false;

        clickPower3.interactable = false;

        clickPower4.interactable = false;
    }

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");

        if(TotalClicks >= autoclickUpgrade) {
            autoclick1.interactable = true; 
        }

        if(TotalClicks >= autoclickUpgrade2) {
            autoclick2.interactable = true; 
        }

        if(TotalClicks >= autoclickUpgrade3) {
            autoclick3.interactable = true; 
        }

        if(TotalClicks >= autoclickUpgrade4) {
            autoclick4.interactable = true; 
        }
    }

    public void AutoClickUpgrade()
    {
        if(!hasAutoClick1 && TotalClicks >= autoclickUpgrade)
        {
            TotalClicks -= autoclickUpgrade;
            hasAutoClick1 = true;
        }
    }

    public void AutoClickUpgrade2()
    {
        if(!hasAutoClick2 && TotalClicks >= autoclickUpgrade2)
        {
            TotalClicks -= autoclickUpgrade2;
            hasAutoClick2 = true;
        }
    }
    public void AutoClickUpgrade3()
    {
        if(!hasAutoClick3 && TotalClicks >= autoclickUpgrade3)
        {
            TotalClicks -= autoclickUpgrade3;
            hasAutoClick3 = true;
        }
    }

    public void AutoClickUpgrade4()
    {
        if(!hasAutoClick4 && TotalClicks >= autoclickUpgrade4)
        {
            TotalClicks -= autoclickUpgrade4;
            hasAutoClick4 = true;
        }
    }

    public void activateButton()
    {
        if(TotalClicks < autoclickUpgrade)
        {
            autoclick1.interactable = false;
        }
        else if(!hasAutoClick1 && TotalClicks >= autoclickUpgrade)
        {
            autoclick1.interactable = true;
        }
        else
        {
            autoclick1.interactable = true;
        }
    }
    
    public void activateButton2()
    {
        if(TotalClicks < autoclickUpgrade2)
        {
            autoclick2.interactable = false;
        }
        else if(!hasAutoClick2 && TotalClicks >= autoclickUpgrade2)
        {
            autoclick2.interactable = true;
        }
        else
        {
            autoclick2.interactable = true;
        }
    }

    public void activateButton3()
    {
        if(TotalClicks < autoclickUpgrade3)
        {
            autoclick3.interactable = false;
        }
        else if(!hasAutoClick3 && TotalClicks >= autoclickUpgrade3)
        {
            autoclick3.interactable = true;
        }
        else
        {
            autoclick3.interactable = true;
        }
    }

    public void activateButton4()
    {
        if(TotalClicks < autoclickUpgrade4)
        {
            autoclick4.interactable = false;
        }
        else if(!hasAutoClick4 && TotalClicks >= autoclickUpgrade4)
        {
            autoclick4.interactable = true;
        }
        else
        {
            autoclick4.interactable = true;
        }
    }

    private void Update()
    {

        if(hasAutoClick1)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("0");

            autoclick1.interactable = false;
        }

        if(hasAutoClick2)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 2;

            ClicksTotalText.text = TotalClicks.ToString("0");

            autoclick2.interactable = false;
        }

        if(hasAutoClick3)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 4;

            ClicksTotalText.text = TotalClicks.ToString("0");

            autoclick3.interactable = false;
        }

        if(hasAutoClick4)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 8;

            ClicksTotalText.text = TotalClicks.ToString("0");

            autoclick4.interactable = false;
        }
    }
}