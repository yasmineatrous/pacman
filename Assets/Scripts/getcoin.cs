using System.Collections;
using System.Collections.Generic;


using UnityEngine;


public class GetCoin : MonoBehaviour
{
    // This method is called when a collider enters the trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other collider belongs to the player
        if (other.CompareTag("Player"))
        {   
            // Increase the score
            COINCOIN.score0 += 1;
            // Destroy the coin GameObject
            Destroy(gameObject);
        }
    }
}
