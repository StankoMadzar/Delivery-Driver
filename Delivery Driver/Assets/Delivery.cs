using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1); 
    [SerializeField] Color32 noPackageColor = new Color32(0, 0, 0, 0);
    [SerializeField] float DestroyAfterTimer = 0.1f;
    bool hasPackage = false; //default value is false
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch");    
    }

    private void OnTriggerEnter2D(Collider2D other) //ima i on trigger exit za kad izadje iz objekta
    {
        if (other.tag == "Package" && !hasPackage) //hasPackage == false
        {
            Debug.Log("Package picked up");
            hasPackage = true; 
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, DestroyAfterTimer);
        }
        else if (other.tag == "Delivery" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
