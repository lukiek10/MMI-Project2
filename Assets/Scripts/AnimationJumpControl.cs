using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationJumpControl : MonoBehaviour
{
    public GameObject theNinja;


 
    void Update(){
        if (Input.GetButtonDown("Jump"))
        {

            theNinja.GetComponent<Animator>().Play("Jumping");
        }
        
    }
}
