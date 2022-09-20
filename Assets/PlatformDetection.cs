using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDetection : MonoBehaviour
{
    public Canvas message;

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.tag == "Ground")
        {
            message.enabled = true;     
        }
    }

  
}
