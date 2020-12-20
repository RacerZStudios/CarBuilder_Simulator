using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone_Audio : MonoBehaviour
{
    // phone rings, player answers the call or does not anwer and receives a penalty. 
    private AudioClip phoneClip;
    private AudioSource source;
    public bool answered;
    public GameObject player;
    public GameObject answerPanel; 
    private void Start()
    {
        phoneClip = GetComponent<AudioClip>();
        source = GetComponent<AudioSource>();
        while(answered != true)
        {
            StartCoroutine(PlayPhoneAudio());
            break; 
        }
    }

    IEnumerator PlayPhoneAudio()
    {
        yield return new WaitForSeconds(0.5f);
        source.Play(); 
        source.loop = true; 
        yield return new WaitForSeconds(0.5f);
        source.loop = false;
        yield return new WaitForSeconds(0.5f);
        source.loop = true;
        yield return new WaitForSeconds(0.5f);
        source.loop = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject == player)
        {
            if(Input.GetKeyDown(KeyCode.Y)) // temp input 
            {
                answerPanel.SetActive(true); 
                answered = true;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                answered = false;
                answerPanel.SetActive(false);
            }
        }
    }
}
