using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

 private void OnCollisionEnter(Collision other)
    {
        if(checkpointTracker.triggerCheckpoints == checkpointTracker.numberOfCheckpoints && other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Win");
        }
        else
        {
            print("Cheater");
        }
    }
}
