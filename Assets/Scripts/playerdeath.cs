using System.Collections;
using System.Collections.Generic;


using UnityEngine;



public class PlayerDeath : MonoBehaviour
{
    // This method is called when the collider enters another collider marked as trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider belongs to the player (you can use tags or layers for this)
        if (other.CompareTag("Player"))
        {
            // Destroy the player GameObject
            Destroy(other.gameObject);
         
        }
    }
}
