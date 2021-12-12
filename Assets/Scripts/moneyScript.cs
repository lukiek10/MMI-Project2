using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyScript : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            
         
            Destroy(gameObject);
            ScoreManager.instance.AddPoint();
            

        }

    }


}


