using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D other) {
        
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("player delete");
            Destroy(other.gameObject);
            
        }
    }

}