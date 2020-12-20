using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int amount;
    public int currentAamount; 
    public bool noDecision;
    public bool canBuy; 
    public bool white, black, red, grey, pink, magenta, orange, green, yellow, cyan, blue, brown;
    public Text amountText;
    public bool helpedClient1; 

    public void Amount()
    {
        currentAamount = 100;
        if (noDecision == true)
            amount = currentAamount;
        amountText.text = currentAamount.ToString(); 
    }

    public void DecreaseAmount()
    {
        if(white == true)
        {
            amount = 100;
            return;
        }
        if (black == true)
        {
            amount -= 15;
            if(amount < -15)
            {
                amount = 85;
                currentAamount = amount;
                amountText.text = amount.ToString();
            }
            return;
        }
        if (red == true)
        {
            amount -= 3;
            if(amount < -3)
            {
                amount = 97;
                currentAamount = amount;
                amountText.text = amount.ToString();
            }
            return; 
        }             
    }

    public void HelpedClient()
    {
        if (helpedClient1 == true)
        {
            amount += 15 + currentAamount;
            if (amount >= 0)
            {
                currentAamount += amount; 
                amountText.text = amount.ToString();
                if(amount >= currentAamount)
                {
                    amount += currentAamount;
                    helpedClient1 = false;
                }
            }
            return;
        }
    }
}