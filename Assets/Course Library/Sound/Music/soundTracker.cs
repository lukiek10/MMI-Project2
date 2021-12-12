using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTracker : MonoBehaviour
{
    public AudioSource[] soundFX;

    
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            soundFX[0].Play();
        }
    }
}
