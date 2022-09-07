using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCrash : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("aman");    
    }

    private void OnTriggerEnter2D(Collider2D other) //ima i on trigger exit za kad izadje iz objekta
    {
        Debug.Log("What Happened?");    
    }
}
