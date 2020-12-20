using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfSelected : MonoBehaviour
{
    [SerializeField] public MoneyManager m;
    [SerializeField] public GameObject car;
    [SerializeField] public Renderer carMat;
    public bool[] vs;

    public void CheckForSelectedWhite()
    {
        m.white = true; 
        if(m.white == true)
        {
            vs[0] = m.white;
            m.DecreaseAmount();
            // default color 
        }    
    }

    public void CheckForSelectedBlack()
    {
        m.black = true;
        if (m.black == true)
        {
            vs[1] = m.black;
            m.DecreaseAmount();
            carMat.material.color = Color.black;
        }
    }

    public void CheckForSelectedRed()
    {
        m.red = true;
        if (m.red == true)
        {
            vs[2] = m.red;
            m.DecreaseAmount();
            carMat.material.color = Color.red;
        }     
    }
}