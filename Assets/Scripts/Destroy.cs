using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Destroy"))
            Destroy(gameObject);
        
            
    }
}
