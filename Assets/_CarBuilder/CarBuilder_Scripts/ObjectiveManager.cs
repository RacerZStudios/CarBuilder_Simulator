using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class ObjectiveManager : MonoBehaviour
{
    public GameObject colorPanel;
    public bool pWhite, pBlack, pRed, pGrey, pPink, pMagenta, pOrange, pGreen, pYellow, pCyan, pBlue, pBrown;
    public Text objectiveText;
    // Client 1
    public GameObject client1Inspect1;

    public void White()
    {
        objectiveText.text = "* Answer the Phone *"; 
        pWhite = true; 
    }

    public void Black()
    {
        objectiveText.text = "* Answer the Phone *";
        pBlack = true;
    }

    public void Red()
    {
        objectiveText.text = "* Answer the Phone *";
        pRed = true;
    }

    public void Grey()
    {
        objectiveText.text = "* Answer the Phone *";
        pGrey = true;
    }

    public void Pink()
    {
        objectiveText.text = "* Answer the Phone *";
        pPink = true;
    }

    public void Magenta()
    {
        objectiveText.text = "* Answer the Phone *";
        pMagenta = true;
    }

    public void Orange()
    {
        objectiveText.text = "* Answer the Phone *";
        pOrange = true;
    }

    public void Green()
    {
        objectiveText.text = "* Answer the Phone *";
        pGreen = true;
    }

    public void Yellow()
    {
        objectiveText.text = "* Answer the Phone *";
        pYellow = true;
    }

    public void Cyan()
    {
        objectiveText.text = "* Answer the Phone *";
        pCyan = true;
    }

    public void Blue()
    {
        objectiveText.text = "* Answer the Phone *";
        pBlue = true;
    }

    public void Brown()
    {
        objectiveText.text = "* Answer the Phone *";
        pBrown = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "O1")
        {
            Debug.Log("This is a simple job, choose a color to assign to this vehicle");
            colorPanel.SetActive(true); 
        }

        if(other.gameObject.name == "C1Trigger")
        {
            Debug.Log("Hello, my name is Kim, I need some help with some basic services with my car, " +
                "Can you inspect it for me?");
            client1Inspect1.gameObject.SetActive(true); 
        }
    }
}