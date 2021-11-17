using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awsdController : MonoBehaviour
{
    private attraction attractionHere;

    private float fspeed = 0f;
    private void Start()
    {
        attractionHere = transform.GetComponent<attraction>();

    }
    void Update()
    {
        fspeed = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            //Do what you want...
            fspeed = 10f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Do what you want...
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Do what you want... 
            fspeed = -10f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            //Do what you want...  
        }
        attractionHere.walkSpeed = fspeed;
    }
}
