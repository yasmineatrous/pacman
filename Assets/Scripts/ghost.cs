using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostAI : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    private NavMeshAgent agent; // Reference to the NavMeshAgent component

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); // Get the NavMeshAgent component attached to the ghost
    }

    void Update()
    {
        if (player != null)
        {
            // Set the destination of the NavMeshAgent to the player's position
            agent.SetDestination(player.position);
        }

    }
}
