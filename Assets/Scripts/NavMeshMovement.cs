using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject obstacle;


    // Start is called before the first frame update
    void Start()
    {
        obstacle = GameObject.FindGameObjectWithTag("Obstacle");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = obstacle.transform.position;
    }

   private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
