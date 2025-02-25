using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

 private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                SceneManager.LoadScene("Win");
            }
            else
            {
                print("Cheater!");
            }
            
        }
        
    }
}
