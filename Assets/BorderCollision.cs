using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Shell" && checkpointTracker.triggerCheckpoints == 4)
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}