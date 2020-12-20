using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForFix : MonoBehaviour
{
    public GameObject player;
    public bool hasCompletedFix;
    public float fixMeter = 0;
    public GameObject wheel;
    [SerializeField] public MoneyManager m; 

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject == player)
        {
            if(Input.GetKey(KeyCode.E))
            {
                fixMeter += 1;
                if(fixMeter >= 5)
                {
                    fixMeter = 5;
                    wheel.GetComponent<WheelCollider>().radius = 0.15f; 
                    wheel.gameObject.transform.localScale = new Vector3(1,1,1);
                    hasCompletedFix = true;
                    m.helpedClient1 = true; 
                    m.HelpedClient(); 
                }

                if(m.helpedClient1 == true)
                {
                    GetComponent<BoxCollider>().enabled = false;
                    return; 
                }
            }
        }
    }
}
