using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    private void Update()
    {
        if(Input.anyKeyDown)
        {
            Application.LoadLevel(1); 
        }
    }
}