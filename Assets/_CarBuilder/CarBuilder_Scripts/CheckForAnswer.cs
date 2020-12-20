using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForAnswer : MonoBehaviour
{
    public bool Answered;
    public GameObject client1;
    public Animator anim;
    public bool client1Ready;
    public Camera clientReadyCamera;
    public GameObject car4_Client1; 

    public void OnClick()
    {
        if(gameObject != null)
        {
            Answered = true;
            anim.Play("Door_Open");
            anim.SetBool("isOpen", true); 
            client1Ready = true; 
            if(Answered == true && client1Ready == true)
            {
                clientReadyCamera.GetComponent<Camera>().enabled = true;
            }
            return;
        }
    }
}
