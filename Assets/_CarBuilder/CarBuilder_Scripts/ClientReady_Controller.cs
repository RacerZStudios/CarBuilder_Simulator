using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientReady_Controller : MonoBehaviour
{
    public bool Answered;
    public GameObject client1;
    public Animator anim;
    public bool client1Ready;
    public Camera clientReadyCamera;
    public GameObject car4_Client1;
    [SerializeField] public CheckForAnswer cA; 

    public void CheckForClientReady()
    {
        if (cA.Answered == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                car4_Client1.SetActive(false);
                clientReadyCamera.GetComponent<Camera>().enabled = false;
                client1.SetActive(true);
                Answered = false;
                anim.Play("Door_Close");
                anim.SetBool("isOpen", false);
                anim.SetBool("isClosed", true);
            }
            return; 
        }
    }

    private void Update()
    {
        CheckForClientReady(); 
    }
}
